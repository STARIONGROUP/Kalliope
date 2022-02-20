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

    using Kalliope.Attributes;

    /// <summary>
    /// A primary role declaration
    /// </summary>
    [Description("")]
    [Domain(isAbstract: false, general: "RoleBase")]
    public class Role : RoleBase
    {
        protected List<string> rolePlayerReferences = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class
        /// </summary>
        public Role()
        {
            this.Multiplicity = Multiplicity.Unspecified;
            this.ObjectTypeInstances = new List<ObjectTypeInstance>();
        }

        /// <summary>
        /// Does this Role have a simple mandatory constraint?
        /// </summary>
        [Description("Does this Role have a simple mandatory constraint?")]
        [Property(name: "IsMandatory", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool IsMandatory { get; set; }

        /// <summary>
        /// The multiplicity specification for a Role of a binary FactType. Affects the uniqueness and mandatory constraints on the opposite Role
        /// </summary>
        [Description("The multiplicity specification for a Role of a binary FactType. Affects the uniqueness and mandatory constraints on the opposite Role")]
        [Property(name: "Multiplicity", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Unspecified")]
        public Multiplicity Multiplicity { get; set; }

        /// <summary>
        /// Restrict the range of possible values for instances of the RolePlayer ObjectType.
        /// To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint.
        /// Commas are used to entered multiple ranges or discrete values.
        /// Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30
        /// </summary>
        [Description("Restrict the range of possible values for instances of the RolePlayer ObjectType. To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint. Commas are used to entered multiple ranges or discrete values. Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30.")]
        [Property(name: "ValueRangeText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ValueRangeText { get; set; }

        /// <summary>
        /// The Name of the simple mandatory constraint on this Role
        /// </summary>
        [Description("The Name of the simple mandatory constraint on this Role")]
        [Property(name: "MandatoryConstraintName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string MandatoryConstraintName { get; set; }

        /// <summary>
        /// The Modality of the simple mandatory constraint on this Role.
        /// Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system
        /// Deontic modality means that data violating the constraint can be recorded
        /// </summary>
        [Description("The Modality of the simple mandatory constraint on this Role. Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system. Deontic modality means that data violating the constraint can be recorded")]
        [Property(name: "MandatoryConstraintModality", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "")]
        public ConstraintModality MandatoryConstraintModality { get; set; }

        /// <summary>
        /// The Name of the implied Role attached to the objectifying EntityType.
        /// An implied binary FactType is created relating the objectifying EntityType to each of the role players of an objectified FactType.
        /// Binary FactTypes with a spanning internal uniqueness constraint and ternary (or higher arity) FactTypes are automatically objectified
        /// </summary>
        [Description("The Name of the implied Role attached to the objectifying EntityType. An implied binary FactType is created relating the objectifying EntityType to each of the role players of an objectified FactType. Binary FactTypes with a spanning internal uniqueness constraint and ternary (or higher arity) FactTypes are automatically objectified")]
        [Property(name: "ObjectificationOppositeRoleName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ObjectificationOppositeRoleName { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("RolePlayer")]
        [Property(name: "RolePlayer", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType")]
        public ObjectType RolePlayer { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="UnaryRoleCardinalityConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "Cardinality", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "UnaryRoleCardinalityConstraint")]
        public UnaryRoleCardinalityConstraint Cardinality { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="RoleValueConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "ValueConstraint", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleValueConstraint")]
        public RoleValueConstraint ValueConstraint { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="RolePlayerRequiredError"/>
        /// </summary>
        [Description("")]
        [Property(name: "RolePlayerRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RolePlayerRequiredError")]
        public RolePlayerRequiredError RolePlayerRequiredError { get; set; }

        [Description("")]
        [Property(name: "ObjectTypeInstances", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeInstance")]
        public List<ObjectTypeInstance> ObjectTypeInstances { get; set; }

        /// <summary>
        /// The calculated value used to populate the derived fact type for this role
        /// </summary>
        [Description("The calculated value used to populate the derived fact type for this role")]
        [Property(name: "DerivedFromCalculatedValue", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValue")]
        public CalculatedPathValue DerivedFromCalculatedValue { get; set; }

        /// <summary>
        /// The constant value used to populate this role in the derived fact type
        /// </summary>
        [Description("The constant value used to populate this role in the derived fact type")]
        [Property(name: "DerivedFromConstant", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathConstant")]
        public PathConstant DerivedFromConstant { get; set; }

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
