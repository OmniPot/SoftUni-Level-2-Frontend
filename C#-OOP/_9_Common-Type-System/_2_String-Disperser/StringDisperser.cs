namespace _2_String_Disperser
{
    using System;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        private StringBuilder totalStringValue = new StringBuilder();
        private List<string> content;

        public StringDisperser(params string[] strings)
        {
            this.content = new List<string>(strings);
            this.content.ForEach(str => this.totalStringValue.Append(str));
        }

        public object Clone()
        {
            return new StringDisperser(this.content.ToArray());
        }

        public int CompareTo(StringDisperser other)
        {
            int result = string.Compare(
                this.totalStringValue.ToString(),
                other.totalStringValue.ToString());

            return result == 0 ? 0 : result == 1 ? 1 : -1;
        }

        public override bool Equals(object obj)
        {
            return string.Equals(this.totalStringValue.ToString(), obj);
        }

        public override int GetHashCode()
        {
            int hash = 19;
            foreach (var str in this.content)
            {
                hash = hash * 31 + str.GetHashCode();
            }
            return hash;
        }

        public override string ToString()
        {
            return this.totalStringValue.ToString();
        }

        IEnumerator<char> IEnumerable<char>.GetEnumerator()
        {
            return this.totalStringValue.ToString().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.totalStringValue.ToString().GetEnumerator();
        }
    }
}
