namespace ExemploDI;

internal sealed class ServicoMostrarCicloDeVida(
    ITransientService servicoTransiente,
    IScopedService servicoScoped,
    ISingletonService servicoSingleton)
{
    public void MostrarDetalhes(string detalhes)
    {
        Console.WriteLine(detalhes);

        MostraServico(servicoTransiente, "Muda sempre");
        MostraServico(servicoScoped, "Permanece durante o ciclo de vida - Muda no escopo");
        MostraServico(servicoSingleton, "Nunca muda");
    }

    private static void MostraServico<T>(T servico, string mensagem)
        where T : IReportServiceLifeTime => Console.WriteLine(
        $"{typeof(T).Name}: {servico.Id} ({mensagem})");

}