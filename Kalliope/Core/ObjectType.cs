// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectType.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2024 Starion Group S.A.
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

    [Description("")]
    [Domain(isAbstract: true, general: "OrmNamedElement")]
    [Container(typeName: "OrmModel", propertyName: "ObjectTypes")]
    public abstract class ObjectType : OrmNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectType"/> class
        /// </summary>
        protected ObjectType()
        {
            this.DataTypeScale = 0;
            this.DataTypeLength = 0;

            this.Abbreviations = new List<NameAlias>();
            this.EntityTypeInstances = new List<EntityTypeInstance>();
            this.EntityTypeSubtypeInstances = new List<EntityTypeSubtypeInstance>();
            this.ObjectTypeInstances = new List<ObjectTypeInstance>();
            this.PlayedRoles = new List<Role>();
            this.ValueTypeInstances = new List<ValueTypeInstance>();
        }
        
        /// <summary>
        /// An instance of this object type can exist without playing any non-identifying roles
        /// </summary>
        [Description("An instance of this object type can exist without playing any non-identifying roles")]
        [Property(name: "IsIndependent", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool IsIndependent { get; set; }

        /// <summary>
        /// Is this ObjectType a self-identifying value or an entity
        /// </summary>
        [Description("Is this ObjectType a self-identifying value or an entity?")]
        public bool IsValueType => this is ValueType; 

        /// <summary>
        /// This object type is externally defined (not used).
        /// </summary>
        /// <remarks>
        /// (DSL) Is this ObjectType defined in an external model
        /// </remarks>
        [Description("Is this ObjectType defined in an external model")]
        [Property(name: "IsExternal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool IsExternal { get; set; }

        /// <summary>
        /// This object type refers to a person, not a thing. A directive to tell the verbalization to use personal pronouns
        /// </summary>
        /// <remarks>
        /// (DSL) Does this ObjectType represent a person instead of a thing? This value is ignored if any direct or indirect supertype is personal 
        /// </remarks>
        [Description("Does this ObjectType represent a person instead of a thing? This value is ignored if any direct or indirect supertype is personal")]
        [Property(name: "IsPersonal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool IsPersonal { get; set; }

        /// <summary>
        /// Cache if IsPersonal is set for one or more supertypes
        /// </summary>
        [Description("Cache if IsPersonal is set for one or more supertypes")]
        [Property(name: "IsSupertypePersonal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool IsSupertypePersonal { get; set; }

        /// <summary>
        /// The number of digits allowed to the right of the decimal point in a value with this DataType
        /// </summary>
        [Description("The number of digits allowed to the right of the decimal point in a value with this DataType")]
        [Property(name: "DataTypeScale", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0")]
        public int DataTypeScale { get; set; }

        /// <summary>
        /// The maximum length of values with this DataType
        /// </summary>
        [Description("The maximum length of values with this DataType")]
        [Property(name: "DataTypeLength", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0")]
        public int DataTypeLength { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the values for this data type are auto-generated.
        /// </summary>
        [Description("A value indicating whether or not the values for this data type are auto-generated")]
        [Property(name: "DataTypeAutoGenerated", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool DataTypeAutoGenerated { get; set; }

        /// <summary>
        /// The name of the reference mode pattern used to identify this element. Derived from a single-role preferred identifier with a ValueType role player
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceMode", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ReferenceMode { get; set; }

        [Description("")]
        [Property(name: "ReferenceModeDecoratedString", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ReferenceModeDecoratedString { get; set; }

        /// <summary>
        /// Restrict the range of possible values for instances of this ObjectType.
        /// To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint.
        /// Commas are used to entered multiple ranges or discrete values.
        /// Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30
        /// </summary>
        [Description("Restrict the range of possible values for instances of this ObjectType. To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint. Commas are used to entered multiple ranges or discrete values. Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30")]
        [Property(name: "ValueRangeText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ValueRangeText { get; set; }

        /// <summary>
        /// The ValueRange property for the ValueType that identifies this EntityType.
        /// The ValueRange property of an EntityType is applied to the identifying role, not directly to the identifying ValueType.
        /// This allows EntityType ValueRanges to be specified independently for multiple EntityTypes identified with the same 
        /// unit-based or general reference mode patterns
        /// </summary>
        [Description("The ValueRange property for the ValueType that identifies this EntityType. The ValueRange property of an EntityType is applied to the identifying role, not directly to the identifying ValueType. This allows EntityType ValueRanges to be specified independently for multiple EntityTypes identified with the same unit-based or general reference mode patterns")]
        [Property(name: "ValueTypeValueRangeText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string ValueTypeValueRangeText { get; set; }

        /// <summary>
        /// Does this ObjectType represent a person instead of a thing?
        /// Used as a verbalization directive to render references to this type using a personal pronoun ('who' instead of 'that')
        /// </summary>
        [Description("Does this ObjectType represent a person instead of a thing? Used as a verbalization directive to render references to this type using a personal pronoun ('who' instead of 'that').")]
        [Property(name: "TreatAsPersonal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool TreatAsPersonal { get; set; }

        [Description("")]
        [Property(name: "IsImplicitBooleanValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false")]
        public bool IsImplicitBooleanValue { get; set; }

        /// <summary>
        /// A description of the derivation rule for this subtype. If a rule is not specified, then this is treated as an asserted subtype
        /// </summary>
        [Description("A description of the derivation rule for this subtype. If a rule is not specified, then this is treated as an asserted subtype")]
        [Property(name: "DerivationNoteDisplay", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "")]
        public string DerivationNoteDisplay { get; set; }

        /// <summary>
        /// Storage options for a derived subtype
        /// </summary>
        [Description("Storage options for a derived subtype")]
        [Property(name: "DerivationStorageDisplay", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "DerivationExpressionStorageType")]
        public DerivationExpressionStorageType DerivationStorageDisplay { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="DataType"/>
        /// </summary>
        [Description("")]
        [Property(name: "DataType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DataType")]
        public DataType DataType { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="FactType"/>
        /// </summary>
        [Description("")]
        [Property(name: "FactType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public FactType FactType { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="MandatoryConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "ImpliedMandatoryConstraint", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "MandatoryConstraint")]
        public MandatoryConstraint ImpliedMandatoryConstraint { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="MandatoryConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "InherentMandatoryConstraint", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "MandatoryConstraint")]
        public MandatoryConstraint InherentMandatoryConstraint { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="NameAlias"/>
        /// </summary>
        [Description("")]
        [Property(name: "Abbreviations", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "NameAlias")]
        public List<NameAlias> Abbreviations { get; set; }

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
        /// Gets or sets the owned <see cref="ValueTypeValueConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "ValueConstraint", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueTypeValueConstraint")]
        public ValueTypeValueConstraint ValueConstraint { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ObjectTypeInstance"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ObjectTypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeInstance")]
        public List<ObjectTypeInstance> ObjectTypeInstances { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="EntityTypeInstance"/>s
        /// </summary>
        [Description("")]
        [Property(name: "EntityTypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "EntityTypeInstance")]
        public List<EntityTypeInstance> EntityTypeInstances { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="EntityTypeInstance"/>s
        /// </summary>
        [Description("")]
        [Property(name: "EntityTypeSubtypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "EntityTypeSubtypeInstance")]
        public List<EntityTypeSubtypeInstance> EntityTypeSubtypeInstances { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="EntityTypeInstance"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ValueTypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueTypeInstance")]
        public List<ValueTypeInstance> ValueTypeInstances { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="SubtypeDerivationRule"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationRule", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "SubtypeDerivationRule")]
        public SubtypeDerivationRule DerivationRule { get; set; }

		/// <summary>
		/// Gets or sets the owned <see cref="ObjectTypeCardinalityRestriction"/>
		/// </summary>
		[Description("")]
        [Property(name: "Cardinality", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeCardinalityRestriction")]
        public ObjectTypeCardinalityRestriction Cardinality { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="SubtypeDerivationExpression"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationExpression", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "SubtypeDerivationExpression")]
        public SubtypeDerivationExpression DerivationExpression { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="EntityTypeRequiresReferenceSchemeError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceSchemeError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "EntityTypeRequiresReferenceSchemeError")]
        public EntityTypeRequiresReferenceSchemeError ReferenceSchemeError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CompatibleSupertypesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "CompatibleSupertypesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CompatibleSupertypesError")]
        public CompatibleSupertypesError CompatibleSupertypesError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="PreferredIdentifierRequiresMandatoryError"/>
        /// </summary>
        [Description("")]
        [Property(name: "PreferredIdentifierRequiresMandatoryError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PreferredIdentifierRequiresMandatoryError")]
        public PreferredIdentifierRequiresMandatoryError PreferredIdentifierRequiresMandatoryError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ObjectTypeDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeDuplicateNameError")]
        public ObjectTypeDuplicateNameError DuplicateNameError { get; set; }
        
        /// <summary>
        /// Gets or sets the referenced <see cref="DataTypeRef"/>
        /// </summary>
        [Description("")]
        [Property(name: "ConceptualDataType", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DataTypeUse")]
        public DataTypeUse ConceptualDataType { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="Role"/>s
        /// </summary>
        [Description("")]
        [Property(name: "PlayedRoles", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Role")]
        public List<Role> PlayedRoles { get; set; }
    }
}
