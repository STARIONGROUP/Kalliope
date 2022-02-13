// -------------------------------------------------------------------------------------------------
// <copyright file="Role.cs" company="RHEA System S.A.">
//
//   Copyright 2022 RHEA System S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
// </copyright>
// ------------------------------------------------------------------------------------------------

namespace Kalliope.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    /// <summary>
    /// A primary role declaration
    /// </summary>
    public class Role : RoleBase
    {
        protected List<string> rolePlayerReferences = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class
        /// </summary>
        public Role()
        {
            this.Multiplicity = Multiplicity.Unspecified;
        }

        /// <summary>
        /// Does this Role have a simple mandatory constraint?
        /// </summary>
        public bool IsMandatory { get; set; }

        /// <summary>
        /// The multiplicity specification for a Role of a binary FactType. Affects the uniqueness and mandatory constraints on the opposite Role
        /// </summary>
        public Multiplicity Multiplicity { get; set; }

        /// <summary>
        /// Restrict the range of possible values for instances of the RolePlayer ObjectType.
        /// To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint.
        /// Commas are used to entered multiple ranges or discrete values.
        /// Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30
        /// </summary>
        public string ValueRangeText { get; set; }

        /// <summary>
        /// The Name of the simple mandatory constraint on this Role
        /// </summary>
        public string MandatoryConstraintName { get; set; }

        /// <summary>
        /// The Modality of the simple mandatory constraint on this Role.
        /// Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system
        /// Deontic modality means that data violating the constraint can be recorded
        /// </summary>
        public ConstraintModality MandatoryConstraintModality { get; set; }

        /// <summary>
        /// The Name of the implied Role attached to the objectifying EntityType.
        /// An implied binary FactType is created relating the objectifying EntityType to each of the role players of an objectified FactType.
        /// Binary FactTypes with a spanning internal uniqueness constraint and ternary (or higher arity) FactTypes are automatically objectified
        /// </summary>
        public string ObjectificationOppositeRoleName { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ObjectType"/>
        /// </summary>
        public ObjectType ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="UnaryRoleCardinalityConstraint"/>
        /// </summary>
        public UnaryRoleCardinalityConstraint Cardinality { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="RoleValueConstraint"/>
        /// </summary>
        public RoleValueConstraint ValueConstraint { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="RolePlayerRequiredError"/>
        /// </summary>
        public RolePlayerRequiredError RolePlayerRequiredError { get; set; }

        /// <summary>
        /// Generates a <see cref="ORMModelElement"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);

            var isMandatory = reader.GetAttribute("_IsMandatory");
            if (!string.IsNullOrEmpty(isMandatory))
            {
                this.IsMandatory = XmlConvert.ToBoolean(isMandatory);
            }

            var multiplicityAttribute = reader.GetAttribute("_Multiplicity");
            if (Enum.TryParse(multiplicityAttribute, out Multiplicity multiplicity))
            {
                this.Multiplicity = multiplicity;
            }

            using (var roleSubtree = reader.ReadSubtree())
            {
                roleSubtree.MoveToContent();

                while (roleSubtree.Read())
                {
                    if (roleSubtree.MoveToContent() == XmlNodeType.Element)
                    {
                        var localName = roleSubtree.LocalName;

                        switch (localName)
                        {
                            case "RolePlayer":
                                var rolePlayerReference = reader.GetAttribute("ref");
                                if (!string.IsNullOrEmpty(rolePlayerReference))
                                {
                                    rolePlayerReferences.Add(rolePlayerReference);
                                }
                                break;
                            case "ValueRestriction":
                                using (var valueRestrictionSubTree = reader.ReadSubtree())
                                {
                                    valueRestrictionSubTree.MoveToContent();
                                    this.ReadValueRestriction(valueRestrictionSubTree);
                                }
                                break;
                            default:
                                Console.WriteLine($"Role.ReadXml did not process the {localName} XML element");
                                break;
                        }
                    }
                }
            }
        }

        private void ReadValueRestriction(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "RoleValueConstraint":
                            using (var valueRestrictionSubTree = reader.ReadSubtree())
                            {
                                valueRestrictionSubTree.MoveToContent();

                                var roleValueConstraint = new RoleValueConstraint();
                                roleValueConstraint.ReadXml(valueRestrictionSubTree);
                                this.ValueConstraint = roleValueConstraint;
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }
    }
}
