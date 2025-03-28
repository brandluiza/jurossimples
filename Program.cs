Console.Clear();

decimal capital, juros, taxa, meses, montante;
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("Calcule aqui seus Juros Simples");
Console.ResetColor();
Console.Write("Capital (R$): ");
capital = Convert.ToDecimal(Console.ReadLine());
Console.Write("Taxa de Juros (%): ");
taxa = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Tempo (meses): ");
meses = Convert.ToDecimal(Console.ReadLine());

juros = capital * (taxa/100) * meses;
montante = capital + juros;
Console.WriteLine($"Juros: {juros:C2}");
Console.WriteLine($"montante: {montante:C2}");