// -------------------------------------------------------------------------------------------------
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
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
 
namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;
 
    using Kalliope.Common;
 
    /// <summary>
    /// A Data Transfer Object that represents a FactType
    /// </summary>
    [Container(typeName: "Objectification", propertyName: "ImpliedFactTypes")]
    [Container(typeName: "ORMModel", propertyName: "FactTypes")]
    public partial class FactType : ORMModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactType"/> class.
        /// </summary>
        public FactType()
        {
            this.FactTypeInstances = new List<string>();
            this.InternalConstraints = new List<string>();
            this.ReadingOrders = new List<string>();
            this.Roles = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition")]
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FactTypeDerivationExpression"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationExpression", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeDerivationExpression")]
        public string DerivationExpression { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationNoteDisplay
        /// </summary>
        [Description("A description of the derivation rule for this FactType")]
        [Property(name: "DerivationNoteDisplay", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string DerivationNoteDisplay { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="RoleProjectedDerivationRule"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationRule", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleProjectedDerivationRule")]
        public string DerivationRule { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationStorageDisplay
        /// </summary>
        [Description("Storage options for a derived FactType")]
        [Property(name: "DerivationStorageDisplay", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "DerivationExpressionStorageType")]
        public DerivationExpressionStorageType DerivationStorageDisplay { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="FactTypeInstance"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "FactTypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeInstance")]
        public List<string> FactTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ImpliedInternalUniquenessConstraintError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ImpliedInternalUniquenessConstraintError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ImpliedInternalUniquenessConstraintError")]
        public string ImpliedInternalUniquenessConstraintError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="SetConstraint"/> instances
        /// </summary>
        [Description("constraints that are internal to a fact type")]
        [Property(name: "InternalConstraints", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetConstraint")]
        public List<string> InternalConstraints { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FactTypeRequiresInternalUniquenessConstraintError"/>
        /// </summary>
        [Description("")]
        [Property(name: "InternalUniquenessConstraintRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeRequiresInternalUniquenessConstraintError")]
        public string InternalUniquenessConstraintRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a IsExternal
        /// </summary>
        [Description("Is this FactType defined in an external model?")]
        [Property(name: "IsExternal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsExternal { get; set; }
 
        /// <summary>
        /// Gets or sets a Name
        /// </summary>
        [Description("The name for this FactType. If the Name property is read-only, then it is a generated name based on primary reading. If the Name property is editable, then it is the name of an explicit or implicit objectifying EntityType. The editable name can be reset to match the generated name by clearing the property value")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Name { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note")]
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ReadingOrder"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ReadingOrders", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ReadingOrder")]
        public List<string> ReadingOrders { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="FactTypeRequiresReadingError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ReadingRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeRequiresReadingError")]
        public string ReadingRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="RoleBase"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Roles", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleBase")]
        public List<string> Roles { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
