// See https://aka.ms/new-console-template for more information
using static Solid_Applied.LSPClass;

Console.WriteLine("Welcome to SOLID!");


EMailOperations eMail = new SendGridAPIOperation();
eMail.GetStacks();

eMail = new SMTPOperation();
eMail.GetStacks();
