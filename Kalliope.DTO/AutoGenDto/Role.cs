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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace Kalliope.DTO
{
    using System;
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A Data Transfer Object that represents a Role
    /// </summary>
    public partial class Role : RoleBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
            this.Multiplicity = Multiplicity.Unspecified;
            this.ObjectTypeInstances = new List<string>();
        }
 

        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="UnaryRoleCardinalityConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "Cardinality", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "UnaryRoleCardinalityConstraint", allowOverride: false, isOverride: false, isDerived: false)]
        public string Cardinality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="CalculatedPathValue"/>
        /// </summary>
        [Description("The calculated value used to populate the derived fact type for this role")]
        [Property(name: "DerivedFromCalculatedValue", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CalculatedPathValue", allowOverride: false, isOverride: false, isDerived: false)]
        public string DerivedFromCalculatedValue { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="PathConstant"/>
        /// </summary>
        [Description("The constant value used to populate this role in the derived fact type")]
        [Property(name: "DerivedFromConstant", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PathConstant", allowOverride: false, isOverride: false, isDerived: false)]
        public string DerivedFromConstant { get; set; }
 
        /// <summary>
        /// Gets or sets a IsMandatory
        /// </summary>
        [Description("Does this Role have a simple mandatory constraint?")]
        [Property(name: "IsMandatory", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public bool IsMandatory { get; set; }
 
        /// <summary>
        /// Gets or sets a MandatoryConstraintModality
        /// </summary>
        [Description("The Modality of the simple mandatory constraint on this Role. Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system. Deontic modality means that data violating the constraint can be recorded")]
        [Property(name: "MandatoryConstraintModality", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "ConstraintModality", allowOverride: false, isOverride: false, isDerived: false)]
        public ConstraintModality MandatoryConstraintModality { get; set; }
 
        /// <summary>
        /// Gets or sets a MandatoryConstraintName
        /// </summary>
        [Description("The Name of the simple mandatory constraint on this Role")]
        [Property(name: "MandatoryConstraintName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string MandatoryConstraintName { get; set; }
 
        /// <summary>
        /// Gets or sets a Multiplicity
        /// </summary>
        [Description("The multiplicity specification for a Role of a binary FactType. Affects the uniqueness and mandatory constraints on the opposite Role")]
        [Property(name: "Multiplicity", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "Unspecified", typeName: "Multiplicity", allowOverride: false, isOverride: false, isDerived: false)]
        public Multiplicity Multiplicity { get; set; }
 
        /// <summary>
        /// Gets or sets a ObjectificationOppositeRoleName
        /// </summary>
        [Description("The Name of the implied Role attached to the objectifying EntityType. An implied binary FactType is created relating the objectifying EntityType to each of the role players of an objectified FactType. Binary FactTypes with a spanning internal uniqueness constraint and ternary (or higher arity) FactTypes are automatically objectified")]
        [Property(name: "ObjectificationOppositeRoleName", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string ObjectificationOppositeRoleName { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="ObjectTypeInstance"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ObjectTypeInstances", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeInstance", allowOverride: false, isOverride: false, isDerived: false)]
        public List<string> ObjectTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectType"/>
        /// </summary>
        [Description("RolePlayer")]
        [Property(name: "RolePlayer", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectType", allowOverride: false, isOverride: false, isDerived: false)]
        public string RolePlayer { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="RolePlayerRequiredError"/>
        /// </summary>
        [Description("")]
        [Property(name: "RolePlayerRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RolePlayerRequiredError", allowOverride: false, isOverride: false, isDerived: false)]
        public string RolePlayerRequiredError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="RoleValueConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "ValueConstraint", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleValueConstraint", allowOverride: false, isOverride: false, isDerived: false)]
        public string ValueConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets a ValueRangeText
        /// </summary>
        [Description("Restrict the range of possible values for instances of the RolePlayer ObjectType. To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint. Commas are used to entered multiple ranges or discrete values. Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30.")]
        [Property(name: "ValueRangeText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "", allowOverride: false, isOverride: false, isDerived: false)]
        public string ValueRangeText { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
