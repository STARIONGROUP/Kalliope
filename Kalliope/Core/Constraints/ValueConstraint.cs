// -------------------------------------------------------------------------------------------------
// <copyright file="ValueConstraint.cs" company="RHEA System S.A.">
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

    using Kalliope.Common;

    /// <summary>
    /// A constraint limiting the set of allowed values
    /// </summary>
    [Description("")]
    [Domain(isAbstract: true, general: "ORMNamedElement")]
    public abstract class ValueConstraint : ORMNamedElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueConstraint"/> class
        /// </summary>
        protected ValueConstraint()
        {
            this.ValueRanges = new List<ValueRange>();
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
        /// The range of possible values.
        /// To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint. Commas are used to entered multiple ranges or discrete values.
        /// Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30
        /// </summary>
        [Description("The range of possible values. To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint. Commas are used to entered multiple ranges or discrete values. Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30")]
        [Property(name: "Text", aggregation: AggregationKind.None, multiplicity: "1..1", typeKind: TypeKind.String, defaultValue: "", typeName: "")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the contained <see cref="ValueRange"/>s
        /// </summary>
        [Description("")]
        [Property(name: "ValueRanges", aggregation: AggregationKind.Composite, multiplicity: "1..*", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueRange")]
        public List<ValueRange> ValueRanges { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ValueRangeOverlapError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ValueRangeOverlapError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueRangeOverlapError")]
        public ValueRangeOverlapError ValueRangeOverlapError { get; set; }

        /// <summary>
        /// Gets or sets the owned <see cref="ValueConstraintValueTypeDetachedError"/>
        /// </summary>
        [Description("")]
        [Property(name: "ValueTypeDetachedError", aggregation: AggregationKind.Composite, multiplicity: "0..1", typeKind: TypeKind.Object, defaultValue: "", typeName: "ValueConstraintValueTypeDetachedError")]
        public ValueConstraintValueTypeDetachedError ValueTypeDetachedError { get; set; }

        /// <summary>
        /// Gets or sets the referenced <see cref="ConstraintDuplicateNameError"/>
        /// </summary>
        [Description("")]
        [Property(name: "DuplicateNameError", aggregation: AggregationKind.None, multiplicity: "0..1", typeKind: TypeKind.String, defaultValue: "", typeName: "ConstraintDuplicateNameError")]
        public ConstraintDuplicateNameError DuplicateNameError { get; set; }

        /// <summary>
        /// Generates a <see cref="ValueConstraint"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        internal override void ReadXml(XmlReader reader)
        {
            base.ReadXml(reader);

            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ValueRanges":
                            using (var valueRangesSubtree = reader.ReadSubtree())
                            {
                                valueRangesSubtree.MoveToContent();
                                this.ReadValueRanges(valueRangesSubtree);
                            }
                            break;
                        default:
                            throw new NotSupportedException($"{localName} not yet supported");
                    }
                }
            }
        }

        /// <summary>
        /// Reads the <see cref="ValueRange"/> object from its XML representation.
        /// </summary>
        /// <param name="reader">
        /// an instance of <see cref="XmlReader"/> used to read the .orm file
        /// </param>
        private void ReadValueRanges(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.MoveToContent() == XmlNodeType.Element)
                {
                    var localName = reader.LocalName;

                    switch (localName)
                    {
                        case "ValueRange":
                            using (var valueRangeSubtree = reader.ReadSubtree())
                            {
                                valueRangeSubtree.MoveToContent();
                                var valueRange = new ValueRange();
                                valueRange.ReadXml(valueRangeSubtree);

                                valueRange.ValueConstraint = this;
                                this.ValueRanges.Add(valueRange);
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
