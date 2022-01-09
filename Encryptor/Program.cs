Console.WriteLine("Base 64 Encryption / Decryption using .NET");
Console.WriteLine("******************************************");
Console.WriteLine();
int caseDetails = 0;
do
{
    Console.Write("Enter 1 to encrypt, 2 to decrypt & 0 to quit : ");
    string? inputStr = Console.ReadLine();
    if (!String.IsNullOrEmpty(inputStr))
        try
        {
            caseDetails = Int32.Parse(inputStr);
        }
        catch (FormatException)
        {
            caseDetails = -1;
        }
    else
    {
        caseDetails = -1;
    }
    switch (caseDetails)
    {
        case 0:
            Console.WriteLine(Environment.NewLine + "Buh,,byee!!");
            break;
        case 1:
            encrypt();
            break;
        case 2:
            decrypt();
            break;
        default:
            Console.WriteLine(Environment.NewLine + "Wrong Choice Entered!!");
            break;
    }
    Console.WriteLine();
} while (caseDetails != 0);
Console.ReadLine();

void encrypt()
{
    string encrypted = String.Empty;
    Console.Write(Environment.NewLine + "Enter string to encrypt : ");
    string? str = Console.ReadLine();
    if (str != null)
    {
        try
        {
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(str);
            encrypted = Convert.ToBase64String(plainTextBytes);
            Console.WriteLine(Environment.NewLine + encrypted);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine(Environment.NewLine + "Input string is not in valid format");
        }
    }
}

void decrypt()
{
    string decrypted = String.Empty;
    Console.Write(Environment.NewLine + "Enter string to decrypt : ");
    string? str = Console.ReadLine();
    if (str != null)
    {
        try
        {
            byte[] base64EncodedBytes = Convert.FromBase64String(str);
            decrypted = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            Console.WriteLine(Environment.NewLine + decrypted);
        }
        catch (FormatException)
        {
            Console.WriteLine(Environment.NewLine + "Input string is not in valid format");
        }
    }
}
