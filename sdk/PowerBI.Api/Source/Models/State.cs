// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for State.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(StateConverter))]
    public struct State : System.IEquatable<State>
    {
        private State(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// The datamart has invalid state
        /// </summary>
        public static readonly State Invalid = "Invalid";

        /// <summary>
        /// The datamart was initialized
        /// </summary>
        public static readonly State Initialized = "Initialized";

        /// <summary>
        /// The datamart is active
        /// </summary>
        public static readonly State Active = "Active";

        /// <summary>
        /// The datamart is migrating
        /// </summary>
        public static readonly State Migrating = "Migrating";

        /// <summary>
        /// The datamart was evicted
        /// </summary>
        public static readonly State Evicted = "Evicted";

        /// <summary>
        /// The datamart was deleted
        /// </summary>
        public static readonly State Deleted = "Deleted";


        /// <summary>
        /// Underlying value of enum State
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for State
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type State
        /// </summary>
        public bool Equals(State e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to State
        /// </summary>
        public static implicit operator State(string value)
        {
            return new State(value);
        }

        /// <summary>
        /// Implicit operator to convert State to string
        /// </summary>
        public static implicit operator string(State e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum State
        /// </summary>
        public static bool operator == (State e1, State e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum State
        /// </summary>
        public static bool operator != (State e1, State e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for State
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is State && Equals((State)obj);
        }

        /// <summary>
        /// Returns for hashCode State
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}