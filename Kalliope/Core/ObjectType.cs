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
    using System.Xml;

    public abstract class ObjectType : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectType"/> class
        /// </summary>
        protected ObjectType()
        {
            this.DataTypeScale = 0;
            this.DataTypeLength = 0;
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
        /// (DSL) Is this ObjectType defined in an external model?">
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
        /// An informal description of this ObjectType.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Informal Description Editor' tool window
        /// </summary>
        public string DefinitionText { get; set; }

        /// <summary>
        /// A note to associate with this ObjectType.
        /// To insert new lines, use Control-Enter in the dropdown editor, or open the 'ORM Notes Editor' tool window
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// The number of digits allowed to the right of the decimal point in a value with this DataType
        /// </summary>
        public int DataTypeScale { get; set; }

        /// <summary>
        /// The maximum length of values with this DataType
        /// </summary>
        public int DataTypeLength { get; set; }

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
           
        }
    }
}
