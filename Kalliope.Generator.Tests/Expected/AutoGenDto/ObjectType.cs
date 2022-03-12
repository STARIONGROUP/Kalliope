// -------------------------------------------------------------------------------------------------
// <copyright file="ObjectType.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object that represents a ObjectType
    /// </summary>
    [Container(typeName: "ORMModel", propertyName: "ObjectTypes")]
    public abstract partial class ObjectType : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectType"/> class.
        /// </summary>
        protected ObjectType()
        {
            this.Abbreviations = new List<string>();
            this.EntityTypeInstances = new List<string>();
            this.EntityTypeSubtypeInstances = new List<string>();
            this.ObjectTypeInstances = new List<string>();
            this.PlayedRoles = new List<string>();
            this.ValueTypeInstances = new List<string>();
        }
 
        /// <summary>
        /// Gets or sets the unique identifier of the container
        /// </summary>
        public string Container {get; set;}
 

        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="NameAlias"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "Abbreviations", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "NameAlias")]
        public List<string> Abbreviations { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ObjectTypeCardinalityConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "Cardinality", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeCardinalityConstraint")]
        public string Cardinality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CompatibleSupertypesError"/>
        /// </summary>
        [Description("")]
        [Property(name: "CompatibleSupertypesError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "CompatibleSupertypesError")]
        public string CompatibleSupertypesError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="DataTypeRef"/>
        /// </summary>
        [Description("")]
        [Property(name: "ConceptualDataType", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DataTypeRef")]
        public string ConceptualDataType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="DataType"/>
        /// </summary>
        [Description("")]
        [Property(name: "DataType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "DataType")]
        public string DataType { get; set; }
 
        /// <summary>
        /// Gets or sets a DataTypeLength
        /// </summary>
        [Description("The maximum length of values with this DataType")]
        [Property(name: "DataTypeLength", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0", typeName: "")]
        public int DataTypeLength { get; set; }
 
        /// <summary>
        /// Gets or sets a DataTypeScale
        /// </summary>
        [Description("The number of digits allowed to the right of the decimal point in a value with this DataType")]
        [Property(name: "DataTypeScale", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Int32, defaultValue: "0", typeName: "")]
        public int DataTypeScale { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        [Description("")]
        [Property(name: "Definition", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Definition")]
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="SubtypeDerivationExpression"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationExpression", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "SubtypeDerivationExpression")]
        public string DerivationExpression { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationNoteDisplay
        /// </summary>
        [Description("A description of the derivation rule for this subtype. If a rule is not specified, then this is treated as an asserted subtype")]
        [Property(name: "DerivationNoteDisplay", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string DerivationNoteDisplay { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="SubtypeDerivationRule"/>
        /// </summary>
        [Description("")]
        [Property(name: "DerivationRule", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "SubtypeDerivationRule")]
        public string DerivationRule { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationStorageDisplay
        /// </summary>
        [Description("Storage options for a derived subtype")]
        [Property(name: "DerivationStorageDisplay", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Enumeration, defaultValue: "", typeName: "DerivationExpressionStorageType")]
        public DerivationExpressionStorageType DerivationStorageDisplay { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectTypeDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeDuplicateNameError")]
        public string DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="EntityTypeInstance"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "EntityTypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "EntityTypeInstance")]
        public List<string> EntityTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="EntityTypeSubtypeInstance"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "EntityTypeSubtypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "EntityTypeSubtypeInstance")]
        public List<string> EntityTypeSubtypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="FactType"/>
        /// </summary>
        [Description("")]
        [Property(name: "FactType", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "FactType")]
        public string FactType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="MandatoryConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "ImpliedMandatoryConstraint", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "MandatoryConstraint")]
        public string ImpliedMandatoryConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="MandatoryConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "InherentMandatoryConstraint", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "MandatoryConstraint")]
        public string InherentMandatoryConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets a IsExternal
        /// </summary>
        [Description("Is this ObjectType defined in an external model")]
        [Property(name: "IsExternal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsExternal { get; set; }
 
        /// <summary>
        /// Gets or sets a IsImplicitBooleanValue
        /// </summary>
        [Description("")]
        [Property(name: "IsImplicitBooleanValue", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsImplicitBooleanValue { get; set; }
 
        /// <summary>
        /// Gets or sets a IsIndependent
        /// </summary>
        [Description("An instance of this object type can exist without playing any non-identifying roles")]
        [Property(name: "IsIndependent", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsIndependent { get; set; }
 
        /// <summary>
        /// Gets or sets a IsPersonal
        /// </summary>
        [Description("Does this ObjectType represent a person instead of a thing? This value is ignored if any direct or indirect supertype is personal")]
        [Property(name: "IsPersonal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsPersonal { get; set; }
 
        /// <summary>
        /// Gets or sets a IsSupertypePersonal
        /// </summary>
        [Description("Cache if IsPersonal is set for one or more supertypes")]
        [Property(name: "IsSupertypePersonal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsSupertypePersonal { get; set; }
 
        /// <summary>
        /// Gets or sets a IsValueType
        /// </summary>
        [Description("Is this ObjectType a self-identifying value or an entity?")]
        [Property(name: "IsValueType", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool IsValueType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Objectification"/>
        /// </summary>
        [Description("")]
        [Property(name: "NestedPredicate", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Objectification")]
        public string NestedPredicate { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        [Description("")]
        [Property(name: "Note", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "Note")]
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ObjectTypeInstance"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ObjectTypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ObjectTypeInstance")]
        public List<string> ObjectTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="Role"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "PlayedRoles", aggregation: AggregationKind.None, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "Role")]
        public List<string> PlayedRoles { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="UniquenessConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "PreferredIdentifier", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "UniquenessConstraint")]
        public string PreferredIdentifier { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="PreferredIdentifierRequiresMandatoryError"/>
        /// </summary>
        [Description("")]
        [Property(name: "PreferredIdentifierRequiresMandatoryError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "PreferredIdentifierRequiresMandatoryError")]
        public string PreferredIdentifierRequiresMandatoryError { get; set; }
 
        /// <summary>
        /// Gets or sets a ReferenceMode
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceMode", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string ReferenceMode { get; set; }
 
        /// <summary>
        /// Gets or sets a ReferenceModeDecoratedString
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceModeDecoratedString", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string ReferenceModeDecoratedString { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="EntityTypeRequiresReferenceSchemeError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ReferenceSchemeError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "EntityTypeRequiresReferenceSchemeError")]
        public string ReferenceSchemeError { get; set; }
 
        /// <summary>
        /// Gets or sets a TreatAsPersonal
        /// </summary>
        [Description("Does this ObjectType represent a person instead of a thing? Used as a verbalization directive to render references to this type using a personal pronoun ('who' instead of 'that').")]
        [Property(name: "TreatAsPersonal", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.Boolean, defaultValue: "false", typeName: "")]
        public bool TreatAsPersonal { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ValueTypeValueConstraint"/>
        /// </summary>
        [Description("")]
        [Property(name: "ValueConstraint", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueTypeValueConstraint")]
        public string ValueConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets a ValueRangeText
        /// </summary>
        [Description("Restrict the range of possible values for instances of this ObjectType. To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint. Commas are used to entered multiple ranges or discrete values. Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30")]
        [Property(name: "ValueRangeText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string ValueRangeText { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ValueTypeInstance"/> instances
        /// </summary>
        [Description("")]
        [Property(name: "ValueTypeInstances", aggregation: AggregationKind.Composite, multiplicity: "0..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueTypeInstance")]
        public List<string> ValueTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets a ValueTypeValueRangeText
        /// </summary>
        [Description("The ValueRange property for the ValueType that identifies this EntityType. The ValueRange property of an EntityType is applied to the identifying role, not directly to the identifying ValueType. This allows EntityType ValueRanges to be specified independently for multiple EntityTypes identified with the same unit-based or general reference mode patterns")]
        [Property(name: "ValueTypeValueRangeText", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string ValueTypeValueRangeText { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
