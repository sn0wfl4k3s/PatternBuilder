using PatternBuilder;

Email email = new EmailBuilder()
    .To("eduardo@email.com")
    .From("fulano@email.com")
    .Subject("Assunto do e-mail")
    .Body("Teste de envio de e-mail")
    .Build();

Console.WriteLine(email);