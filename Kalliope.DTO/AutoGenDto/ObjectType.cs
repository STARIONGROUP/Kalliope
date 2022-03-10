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
        public List<string> Abbreviations { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ObjectTypeCardinalityConstraint"/>
        /// </summary>
        public string Cardinality { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="CompatibleSupertypesError"/>
        /// </summary>
        public string CompatibleSupertypesError { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="DataTypeRef"/>
        /// </summary>
        public string ConceptualDataType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="DataType"/>
        /// </summary>
        public string DataType { get; set; }
 
        /// <summary>
        /// Gets or sets a DataTypeLength
        /// </summary>
        public int DataTypeLength { get; set; }
 
        /// <summary>
        /// Gets or sets a DataTypeScale
        /// </summary>
        public int DataTypeScale { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Definition"/>
        /// </summary>
        public string Definition { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="SubtypeDerivationExpression"/>
        /// </summary>
        public string DerivationExpression { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationNoteDisplay
        /// </summary>
        public string DerivationNoteDisplay { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="SubtypeDerivationRule"/>
        /// </summary>
        public string DerivationRule { get; set; }
 
        /// <summary>
        /// Gets or sets a DerivationStorageDisplay
        /// </summary>
        public DerivationExpressionStorageType DerivationStorageDisplay { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="ObjectTypeDuplicateNameError"/>
        /// </summary>
        public string DuplicateNameError { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="EntityTypeInstance"/> instances
        /// </summary>
        public List<string> EntityTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="EntityTypeSubtypeInstance"/> instances
        /// </summary>
        public List<string> EntityTypeSubtypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="FactType"/>
        /// </summary>
        public string FactType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="MandatoryConstraint"/>
        /// </summary>
        public string ImpliedMandatoryConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="MandatoryConstraint"/>
        /// </summary>
        public string InherentMandatoryConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets a IsExternal
        /// </summary>
        public bool IsExternal { get; set; }
 
        /// <summary>
        /// Gets or sets a IsImplicitBooleanValue
        /// </summary>
        public bool IsImplicitBooleanValue { get; set; }
 
        /// <summary>
        /// Gets or sets a IsIndependent
        /// </summary>
        public bool IsIndependent { get; set; }
 
        /// <summary>
        /// Gets or sets a IsPersonal
        /// </summary>
        public bool IsPersonal { get; set; }
 
        /// <summary>
        /// Gets or sets a IsSupertypePersonal
        /// </summary>
        public bool IsSupertypePersonal { get; set; }
 
        /// <summary>
        /// Gets or sets a IsValueType
        /// </summary>
        public bool IsValueType { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Objectification"/>
        /// </summary>
        public string NestedPredicate { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="Note"/>
        /// </summary>
        public string Note { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ObjectTypeInstance"/> instances
        /// </summary>
        public List<string> ObjectTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the referenced <see cref="Role"/> instances
        /// </summary>
        public List<string> PlayedRoles { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the referenced <see cref="UniquenessConstraint"/>
        /// </summary>
        public string PreferredIdentifier { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="PreferredIdentifierRequiresMandatoryError"/>
        /// </summary>
        public string PreferredIdentifierRequiresMandatoryError { get; set; }
 
        /// <summary>
        /// Gets or sets a ReferenceMode
        /// </summary>
        public string ReferenceMode { get; set; }
 
        /// <summary>
        /// Gets or sets a ReferenceModeDecoratedString
        /// </summary>
        public string ReferenceModeDecoratedString { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="EntityTypeRequiresReferenceSchemeError"/>
        /// </summary>
        public string ReferenceSchemeError { get; set; }
 
        /// <summary>
        /// Gets or sets a TreatAsPersonal
        /// </summary>
        public bool TreatAsPersonal { get; set; }
 
        /// <summary>
        /// Gets or sets the unique identifier of the contained <see cref="ValueTypeValueConstraint"/>
        /// </summary>
        public string ValueConstraint { get; set; }
 
        /// <summary>
        /// Gets or sets a ValueRangeText
        /// </summary>
        public string ValueRangeText { get; set; }
 
        /// <summary>
        /// Gets or sets a list unique identifiers of the contained <see cref="ValueTypeInstance"/> instances
        /// </summary>
        public List<string> ValueTypeInstances { get; set; }
 
        /// <summary>
        /// Gets or sets a ValueTypeValueRangeText
        /// </summary>
        public string ValueTypeValueRangeText { get; set; }
 
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
