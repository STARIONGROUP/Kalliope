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

namespace Kalliope.Core
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public abstract class ObjectType : ORMNamedElement
    {
        protected List<string> playedRolesReferences = new List<string>();

        protected string preferredIdentifierReference = string.Empty;

        protected string conceptualDataTypeReference = string.Empty;

        protected string dataTypeRef = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectType"/> class
        /// </summary>
        protected ObjectType()
        {
            this.DataTypeScale = 0;
            this.DataTypeLength = 0;

            this.Abbreviations = new List<NameAlias>();
            this.ObjectTypeInstances = new List<ObjectTypeInstance>();
            this.EntityTypeInstances = new List<EntityTypeInstance>();
            this.EntityTypeSubtypeInstances = new List<EntityTypeSubtypeInstance>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectType"/> class
        /// </summary>
        /// <param name="model">
        /// The <see cref="ORMModel"/> that contains the current <see cref="ObjectType"/>
        /// </param>
        internal ObjectType(ORMModel model)
            : this()
        {
            this.Model = model;
        }

        /// <summary>
        /// Gets or sets the container <see cref="ORMModel"/>
        /// </summary>
        public ORMModel Model { get; set; }

        /// <summary>
        /// An instance of this object type can exist without playing any non-identifying roles
        /// </summary>
        public bool IsIndependent { get; set; }

        /// <summary>
        /// Is this ObjectType a self-identifying value or an entity?
        /// </summary>
        public bool IsValueType { get; set; }

        /// <summary>
        /// This object type is externally defined (not used).
        /// </summary>
        /// <remarks>
        /// (DSL) Is this ObjectType defined in an external model
        /// </remarks>
        public bool IsExternal { get; set; }

        /// <summary>
        /// This object type refers to a person, not a thing. A directive to tell the verbalization to use personal pronouns
        /// </summary>
        /// <remarks>
        /// (DSL) Does this ObjectType represent a person instead of a thing? This value is ignored if any direct or indirect supertype is personal 
        /// </remarks>
        public bool IsPersonal { get; set; }

        /// <summary>
        /// Cache if IsPersonal is set for one or more supertypes
        /// </summary>
        public bool IsSupertypePersonal { get; set; }
        
        /// <summary>
        /// The number of digits allowed to the right of the decimal point in a value with this DataType
        /// </summary>
        public int DataTypeScale { get; set; }

        /// <summary>
        /// The maximum length of values with this DataType
        /// </summary>
        public int DataTypeLength { get; set; }

        /// <summary>
        /// The name of the reference mode pattern used to identify this element. Derived from a single-role preferred identifier with a ValueType role player
        /// </summary>
        public string ReferenceMode { get; set; }

        public string ReferenceModeDecoratedString { get; set; }

        /// <summary>
        /// Restrict the range of possible values for instances of this ObjectType.
        /// To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint.
        /// Commas are used to entered multiple ranges or discrete values.
        /// Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30
        /// </summary>
        public string ValueRangeText { get; set; }

        /// <summary>
        /// The ValueRange property for the ValueType that identifies this EntityType.
        /// The ValueRange property of an EntityType is applied to the identifying role, not directly to the identifying ValueType.
        /// This allows EntityType ValueRanges to be specified independently for multiple EntityTypes identified with the same 
        /// unit-based or general reference mode patterns
        /// </summary>
        public string ValueTypeValueRangeText { get; set; }

        /// <summary>
        /// Does this ObjectType represent a person instead of a thing?
        /// Used as a verbalization directive to render references to this type using a personal pronoun ('who' instead of 'that')
        /// </summary>
        public bool TreatAsPersonal { get; set; }

        public bool IsImplicitBooleanValue { get; set; }

        /// <summary>
        /// A description of the derivation rule for this subtype. If a rule is not specified, then this is treated as an asserted subtype
        /// </summary>
        public string DerivationNoteDisplay { get; set; }

        /// <summary>
        /// Storage options for a derived subtype
        /// </summary>
        public DerivationExpressionStorageType DerivationStorageDisplay { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="DataType"/>
        /// </summary>
        public DataType DataType { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="FactType"/>
        /// </summary>
        public FactType FactType { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="MandatoryConstraint"/>
        /// </summary>
        public MandatoryConstraint ImpliedMandatoryConstraint { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="MandatoryConstraint"/>
        /// </summary>
        public MandatoryConstraint InherentMandatoryConstraint { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="NameAlias"/>
        /// </summary>
        public List<NameAlias> Abbreviations { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Definition"/>
        /// </summary>
        public Definition Definition { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Note"/>
        /// </summary>
        public Note Note { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ValueTypeValueConstraint"/>
        /// </summary>
        public ValueTypeValueConstraint ValueConstraint { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ObjectTypeInstance"/>s
        /// </summary>
        public List<ObjectTypeInstance> ObjectTypeInstances { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="EntityTypeInstance"/>s
        /// </summary>
        public List<EntityTypeInstance> EntityTypeInstances { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="EntityTypeInstance"/>s
        /// </summary>
        public List<EntityTypeSubtypeInstance> EntityTypeSubtypeInstances { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="SubtypeDerivationRule"/>
        /// </summary>
        public SubtypeDerivationRule DerivationRule { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ObjectTypeCardinalityConstraint"/>
        /// </summary>
        public ObjectTypeCardinalityConstraint Cardinality { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="SubtypeDerivationExpression"/>
        /// </summary>
        public SubtypeDerivationExpression DerivationExpression { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="EntityTypeRequiresReferenceSchemeError"/>
        /// </summary>
        public EntityTypeRequiresReferenceSchemeError ReferenceSchemeError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="CompatibleSupertypesError"/>
        /// </summary>
        public CompatibleSupertypesError CompatibleSupertypesError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="PreferredIdentifierRequiresMandatoryError"/>
        /// </summary>
        public PreferredIdentifierRequiresMandatoryError PreferredIdentifierRequiresMandatoryError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="Objectification"/>
        /// </summary>
        public Objectification NestedPredicate { get; set; }

        /// <summary>
        /// Generates a <see cref="ORMModel"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);
            
            var isImplicitBooleanValue = reader.GetAttribute("IsImplicitBooleanValue");
            if (isImplicitBooleanValue != null)
            {
                this.IsImplicitBooleanValue = XmlConvert.ToBoolean(isImplicitBooleanValue);
            }

            var isIndependent = reader.GetAttribute("IsIndependent");
            if (isIndependent != null)
            {
                this.IsIndependent = XmlConvert.ToBoolean(isIndependent);
            }
            
            this.ReferenceMode = reader.GetAttribute("_ReferenceMode");

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Definitions":
                            using (var definitionSubtree = reader.ReadSubtree())
                            {
                                definitionSubtree.MoveToContent();
                                this.ReadDefinitions(definitionSubtree);
                            }
                            break;
                        case "Notes":
                            using (var notesSubtree = reader.ReadSubtree())
                            {
                                notesSubtree.MoveToContent();
                                this.ReadNotes(notesSubtree);
                            }
                            break;
                        case "PlayedRoles":
                            using (var roleSubtree = reader.ReadSubtree())
                            {
                                roleSubtree.MoveToContent();
                                this.ReadPlayedRoles(roleSubtree);
                            }
                            break;
                        case "PreferredIdentifier":
                            using (var preferredIdentifierSubtree = reader.ReadSubtree())
                            {
                                if (preferredIdentifierSubtree.MoveToContent() == XmlNodeType.Element)
                                {
                                    if (preferredIdentifierSubtree.LocalName == "PreferredIdentifier")
                                    {
                                        var reference = preferredIdentifierSubtree.GetAttribute("ref");
                                        if (!string.IsNullOrEmpty(reference))
                                        {
                                            this.preferredIdentifierReference = reference;
                                        }
                                    }
                                }
                            }
                            break;
                        case "ConceptualDataType":
                            if (reader.MoveToContent() == XmlNodeType.Element)
                            {
                                var reference = reader.GetAttribute("ref");
                                if (!string.IsNullOrEmpty(reference))
                                {
                                    this.conceptualDataTypeReference = reference;
                                }
                            }
                            break;
                        case "NestedPredicate":
                            using (var nestedPredicateSubtree = reader.ReadSubtree())
                            {
                                nestedPredicateSubtree.MoveToContent();
                                this.ReadNestedPredicate(nestedPredicateSubtree);
                            }
                            break;
                        case "ValueRestriction":
                            //TODO: implement ValueRestriction
                            break;
                        case "ValueConstraint":

                            using (var valueTypeValueConstraintSubtree = reader.ReadSubtree())
                            {
                                valueTypeValueConstraintSubtree.MoveToContent();
                                var valueTypeValueConstraint = new ValueTypeValueConstraint();
                                valueTypeValueConstraint.ReadXml(valueTypeValueConstraintSubtree);
                                this.ValueConstraint = valueTypeValueConstraint;
                            }
                            
                            break;
                        case "SubtypeDerivationRule":
                            using (var subtypeDerivationRuleSubtree = reader.ReadSubtree())
                            {
                                subtypeDerivationRuleSubtree.MoveToContent();
                                var subtypeDerivationRule = new SubtypeDerivationRule();
                                subtypeDerivationRule.ReadXml(subtypeDerivationRuleSubtree);
                                this.DerivationRule = subtypeDerivationRule;
                            }

                            break;
                        default:
                            throw new System.NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the contained <see cref="Definition"/>s
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadDefinitions(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Definition":
                            using (var definitionSubtree = reader.ReadSubtree())
                            {
                                definitionSubtree.MoveToContent();
                                var definition = new Definition();
                                definition.ReadXml(definitionSubtree);
                                this.Definition = definition;
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the contained <see cref="Note"/>s
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadNotes(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "Note":

                            using (var noteSubtree = reader.ReadSubtree())
                            {
                                noteSubtree.MoveToContent();
                                var note = new Note();
                                note.ReadXml(noteSubtree);
                                this.Note = note;
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// reads the referenced played Role
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadPlayedRoles(XmlReader reader)
        {
            while (reader.Read())
            {
                var localName = reader.LocalName;

                if (localName == "Role")
                {
                    var roleReference = reader.GetAttribute("ref");
                    if (!string.IsNullOrEmpty(roleReference))
                    {
                        this.playedRolesReferences.Add(roleReference);
                    }
                }
            }
        }

        /// <summary>
        /// reads the <see cref="Objectification"/>
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadNestedPredicate(XmlReader reader)
        {
            var objectification = new Objectification();
            objectification.ReadXml(reader);

            this.NestedPredicate = objectification;
            objectification.NestingType = this;
        }
    }
}
