using System.Linq;

namespace CrackingTheCodingInterview.chapter1
{
    public class StringBuilder
    {
        private char[] container;
        private int containerFillIndex;

        public StringBuilder()
        {
           // Char array which holds the chars of appended string value at an instance
           container = new char[1];

           // The index value till which the container is filled at an instance
           containerFillIndex = 0;
        }

        public void Append(string input)
        {
            // Check whether container length is sufficient to store new input
            if (IsOverFlow(input))
                ResetContainer(input.Length);

            // Once the container is ready, store the input
            InsertToStringContainer(input);
        }

        public override string ToString()
        {
            // Gets the string value stored in container at an instance
            return new string(container).Substring(0, containerFillIndex);
        }

        private void InsertToStringContainer(string input)
        {
            char[] inputCharArray = input.ToCharArray();

            // Store each character of input into the container
            foreach (var c in inputCharArray)
            {
                container[containerFillIndex] = c;
                containerFillIndex++;
            }
        }

        private bool IsOverFlow(string input)
        {
            int containerLength = container.Length;
            int inputLength = input.ToCharArray().Count();

            // Check whether already stored string length along with new input length, 
            // exceeds the current container length
            if (containerFillIndex + inputLength > containerLength)
                return true;

            return false;
        }

        private void ResetContainer(int inputLength)
        {
            // Save current container chars in a temp variable
            char[] tempContainer = container;

            // Calculate new length of container
            int containerLength = container.Length;
            int newLength = 2 * containerLength;
            while (newLength < inputLength + containerFillIndex)
                newLength *= 2;

            // Reset length of container to new length
            container = new char[newLength];

            // Store current container chars (saved in temp variable),
            // back to container
            int i = 0;
            foreach (var c in tempContainer)
            {
                container[i] = c;
                i++;
            }
        }
    }
}