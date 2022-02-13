﻿// -------------------------------------------------------------------------------------------------
// <copyright file="FactType.cs" company="RHEA System S.A.">
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
    /// A fact type directly specified by the modeler
    /// </summary>
    public class FactType : ORMModelElement
    {
        private readonly List<string> setConstraintReferences = new List<string>();

        private readonly List<string> setComparisonConstraintReferences = new List<string>();
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FactType"/> class
        /// </summary>
        public FactType()
        {
            this.ReadingOrders = new List<ReadingOrder>();
            this.Roles = new List<RoleBase>();
            this.FactTypeInstances = new List<FactTypeInstance>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FactType"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="FactType"/>
        /// </param>
        internal FactType(ORMModel model)
            : this()
        {
            this.Model = model;
            model.FactTypes.Add(this);
        }

        /// <summary>
        /// Gets or sets the container <see cref="ORMModel"/>
        /// </summary>
        public ORMModel Model { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Definition"/>
        /// </summary>
        public Definition Definition { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        public Note Note { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="FactTypeDerivationExpression"/>
        /// </summary>
        public FactTypeDerivationExpression DerivationExpression { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ReadingOrder"/>s
        /// </summary>
        public List<ReadingOrder> ReadingOrders { get; set; }

        /// <summary>
        /// This fact type is externally defined (not used)
        /// </summary>
        public bool IsExternal { get; set; }
        
        /// <summary>
        /// The name for this FactType.
        /// If the Name property is read-only, then it is a generated name based on primary reading.
        /// If the Name property is editable, then it is the name of an explicit or implicit objectifying EntityType
        /// The editable name can be reset to match the generated name by clearing the property value
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the derivation rule for this FactType
        /// </summary>
        public string DerivationNoteDisplay { get; set; }

        public DerivationExpressionStorageType DerivationStorageDisplay { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="RoleBase"/>s
        /// </summary>
        public List<RoleBase> Roles { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FactTypeInstance"/>s
        /// </summary>
        public List<FactTypeInstance> FactTypeInstances { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="FactTypeRequiresReadingError"/>
        /// </summary>
        public FactTypeRequiresReadingError ReadingRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="FactTypeRequiresInternalUniquenessConstraintError"/>
        /// </summary>
        public FactTypeRequiresInternalUniquenessConstraintError InternalUniquenessConstraintRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ImpliedInternalUniquenessConstraintError"/>
        /// </summary>
        public ImpliedInternalUniquenessConstraintError ImpliedInternalUniquenessConstraintError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="RoleProjectedDerivationRule"/>
        /// </summary>
        public RoleProjectedDerivationRule DerivationRule { get; set; }

        /// <summary>
        /// Generates a <see cref="FactType"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);

            this.Name = reader.GetAttribute("_Name");

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "FactRoles":
                            using (var rolesSubtree = reader.ReadSubtree())
                            {
                                rolesSubtree.MoveToContent();
                                this.ReadFactRoles(rolesSubtree);
                            }
                            break;
                        case "ReadingOrders":
                            using (var readingOrdersSubtree = reader.ReadSubtree())
                            {
                                readingOrdersSubtree.MoveToContent();
                                this.ReadReadingOrders(readingOrdersSubtree);
                            }
                            break;
                        case "InternalConstraints":
                            using (var internalConstraintsSubtree = reader.ReadSubtree())
                            {
                                internalConstraintsSubtree.MoveToContent();
                                this.ReadInternalConstraints(internalConstraintsSubtree);
                            }
                            break;
                        case "DerivationRule":
                            using (var derivationRuleSubtree = reader.ReadSubtree())
                            {
                                derivationRuleSubtree.MoveToContent();
                                this.ReadDerivationRule(derivationRuleSubtree);
                            }
                            break;
                        case "ImpliedByObjectification":
                            this.ReadImpliedByObjectification(reader);
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="Role"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal virtual void ReadImpliedByObjectification(XmlReader reader)
        {
            throw new InvalidOperationException("shall only be implemented by ImpliedFact");
        }

        /// <summary>
        /// Reads <see cref="Role"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal virtual void ReadFactRoles(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Role":
                            using (var roleSubtree = reader.ReadSubtree())
                            {
                                roleSubtree.MoveToContent();
                                var role = new Role();
                                role.ReadXml(roleSubtree);
                                this.Roles.Add(role);
                            }
                            break;
                        case "RoleProxy":
                            using (var roleProxySubtree = reader.ReadSubtree())
                            {
                                roleProxySubtree.MoveToContent();
                                var roleProxy = new RoleProxy();
                                roleProxy.ReadXml(roleProxySubtree);
                                this.Roles.Add(roleProxy);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="ReadingOrder"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadReadingOrders(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ReadingOrder":
                            using (var readingOrderSubtree = reader.ReadSubtree())
                            {
                                readingOrderSubtree.MoveToContent();
                                var readingOrder = new ReadingOrder();
                                readingOrder.ReadXml(readingOrderSubtree);

                                this.ReadingOrders.Add(readingOrder);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="SetConstraint"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadInternalConstraints(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "MandatoryConstraint":
                            var mandatoryConstraintReference = reader.GetAttribute("ref");
                            if (string.IsNullOrEmpty(mandatoryConstraintReference))
                            {
                                this.setConstraintReferences.Add(mandatoryConstraintReference);
                            }
                            break;
                        case "UniquenessConstraint":
                            var uniquenessConstraintReference = reader.GetAttribute("ref");
                            if (string.IsNullOrEmpty(uniquenessConstraintReference))
                            {
                                this.setConstraintReferences.Add(uniquenessConstraintReference);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads <see cref="DerivationRule"/>s from the .orm file
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadDerivationRule(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "DerivationExpression":
                            using (var derivationExpressionSubtree = reader.ReadSubtree())
                            {
                                derivationExpressionSubtree.MoveToContent();
                                var factTypeDerivationExpression = new FactTypeDerivationExpression();
                                factTypeDerivationExpression.ReadXml(derivationExpressionSubtree);

                                this.DerivationExpression = factTypeDerivationExpression;
                            }
                            break;
                        case "FactTypeDerivationPath":
                            using (var factTypeDerivationPathSubtree = reader.ReadSubtree())
                            {
                                factTypeDerivationPathSubtree.MoveToContent();
                                var factTypeDerivationExpression = new FactTypeDerivationPath();
                                factTypeDerivationExpression.ReadXml(factTypeDerivationPathSubtree);
                                
                                Console.WriteLine("TODO: no reference from FactType.FactTypeDerivationPath");
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
