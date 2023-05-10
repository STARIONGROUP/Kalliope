// -------------------------------------------------------------------------------------------------
// <copyright file="FactType.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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
    using System.Collections.Generic;

    using Kalliope.Common;

    /// <summary>
    /// A fact type directly specified by the modeler
    /// </summary>
    [Description("A fact type directly specified by the modeler")]
    [Domain(isAbstract: false, general: "OrmModelElement")]
    [Container(typeName: "Objectification", propertyName: "ImpliedFactTypes")]
    [Container(typeName: "OrmModel", propertyName: "FactTypes")]
    public class FactType : OrmModelElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactType"/> class
        /// </summary>
        public FactType()
        {
            this.ReadingOrders = new List<ReadingOrder>();
            this.Roles = new List<RoleBase>();
            this.FactTypeInstances = new List<FactTypeInstance>();
            this.InternalConstraints = new List<SetConstraint>();
        }
        
        /// <summary>
        /// Gets or sets the owned <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition")]
        public Definition Definition { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note")]
        public Note Note { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="FactTypeDerivationExpression"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationExpression", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeDerivationExpression")]
        public FactTypeDerivationExpression DerivationExpression { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ReadingOrder"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ReadingOrders", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ReadingOrder")]
        public List<ReadingOrder> ReadingOrders { get; set; }

        /// <summary>
        /// This fact type is externally defined (not used)
        /// </summary>
        [Description("Is this FactType defined in an external model?")]
        [Property(name: "IsExternal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool IsExternal { get; set; }

        /// <summary>
        /// The name for this FactType.
        /// If the Name property is read-only, then it is a generated name based on primary reading.
        /// If the Name property is editable, then it is the name of an explicit or implicit objectifying EntityType
        /// The editable name can be reset to match the generated name by clearing the property value
        /// </summary>
        [Description("The name for this FactType. If the Name property is read-only, then it is a generated name based on primary reading. If the Name property is editable, then it is the name of an explicit or implicit objectifying EntityType. The editable name can be reset to match the generated name by clearing the property value")]
        [Property(name: "Name", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string Name { get; set; }

        /// <summary>
        /// A description of the derivation rule for this FactType
        /// </summary>
        [Description("A description of the derivation rule for this FactType")]
        [Property(name: "DerivationNoteDisplay", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string DerivationNoteDisplay { get; set; }

        /// <summary>
        /// Storage options for a derived FactType
        /// </summary>
        [Description("Storage options for a derived FactType")]
        [Property(name: "DerivationStorageDisplay", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "DerivationExpressionStorageType")]
        public DerivationExpressionStorageType DerivationStorageDisplay { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="RoleBase"/>s
        /// </summary>
        [Description("")]
        [Property(name: "Roles", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "RoleBase")]
        public List<RoleBase> Roles { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="FactTypeInstance"/>s
        /// </summary>
        [Description("")]
        [Property(name: "FactTypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeInstance")]
        public List<FactTypeInstance> FactTypeInstances { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="FactTypeRequiresReadingError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ReadingRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeRequiresReadingError")]
        public FactTypeRequiresReadingError ReadingRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="FactTypeRequiresInternalUniquenessConstraintError"/>
        /// </summary>
        [Description("")]
        [Property(name: "InternalUniquenessConstraintRequiredError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeRequiresInternalUniquenessConstraintError")]
        public FactTypeRequiresInternalUniquenessConstraintError InternalUniquenessConstraintRequiredError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ImpliedInternalUniquenessConstraintError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ImpliedInternalUniquenessConstraintError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ImpliedInternalUniquenessConstraintError")]
        public ImpliedInternalUniquenessConstraintError ImpliedInternalUniquenessConstraintError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="FactTypeDerivationRule"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationRule", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactTypeDerivationRule")]
        public FactTypeDerivationRule DerivationRule { get; set; }

        /// <summary>
        /// Gets or sets the constraints that are internal to the <see cref="FactType"/>
        /// </summary>
        [Description("constraints that are internal to a fact type")]
        [Property(name: "InternalConstraints", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "SetConstraint")]
        public List<SetConstraint> InternalConstraints { get; set; }
    }
}
