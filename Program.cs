class Program
{
    static void Main(string[] args)
    {
        // Test cases from the challenge
        Console.WriteLine(OldPhoneKeypad.OldPhonePad("33#"));               
        Console.WriteLine(OldPhoneKeypad.OldPhonePad("227*#"));             
        Console.WriteLine(OldPhoneKeypad.OldPhonePad("4433555 555666#"));   
        Console.WriteLine(OldPhoneKeypad.OldPhonePad("8 88777444666*664#"));

        Console.ReadLine(); // keeps console open
    }
}
