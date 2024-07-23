using PatternBuilder;

Email email = new EmailBuilder()
    .AddTo("eduardo@email.com")
    .AddFrom("fulano@email.com")
    .AddSubject("Assunto do e-mail")
    .AddBody("Teste de envio de e-mail")
    .Build();

Console.WriteLine(email);