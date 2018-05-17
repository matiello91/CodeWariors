namespace Create_Phone_Number
{
    public class Kata
    {
        public string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length != 10) {
                throw new System.Exception("Array lenght !=10");
            }
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }

    }
}
