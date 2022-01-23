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

namespace Kalliope.Core
{
    /// <summary>
    /// A primary role declaration
    /// </summary>
    public class Role : RoleBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class
        /// </summary>
        public Role()
        {
            this.Multiplicity = Multiplicity.Unspecified;
        }

        /// <summary>
        /// Does this Role have a simple mandatory constraint?
        /// </summary>
        public bool IsMandatory { get; set; }

        /// <summary>
        /// The multiplicity specification for a Role of a binary FactType. Affects the uniqueness and mandatory constraints on the opposite Role
        /// </summary>
        public Multiplicity Multiplicity { get; set; }

        /// <summary>
        /// Restrict the range of possible values for instances of the RolePlayer ObjectType.
        /// To specify a range, use '..' between the range endpoints, square brackets to specify a closed endpoint, and parentheses to specify an open endpoint.
        /// Commas are used to entered multiple ranges or discrete values.
        /// Example: {[10..20), 30} specifies all values between 10 and 20 (but not including 20) and the value 30
        /// </summary>
        public string ValueRangeText { get; set; }

        /// <summary>
        /// The Name of the simple mandatory constraint on this Role
        /// </summary>
        public string MandatoryConstraintName { get; set; }

        /// <summary>
        /// The Modality of the simple mandatory constraint on this Role.
        /// Alethic modality means the constraint is structurally enforced and data violating the constraint cannot be entered in the system
        /// Deontic modality means that data violating the constraint can be recorded
        /// </summary>
        public ConstraintModality MandatoryConstraintModality { get; set; }

        /// <summary>
        /// The Name of the implied Role attached to the objectifying EntityType.
        /// An implied binary FactType is created relating the objectifying EntityType to each of the role players of an objectified FactType.
        /// Binary FactTypes with a spanning internal uniqueness constraint and ternary (or higher arity) FactTypes are automatically objectified
        /// </summary>
        public string ObjectificationOppositeRoleName { get; set; }
    }
}
