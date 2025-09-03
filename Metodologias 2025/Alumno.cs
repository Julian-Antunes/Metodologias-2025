using Metodologias_2025;

public class Alumno : Persona
{
    public int legajo;
    public decimal promedio;
    private IEstrategia estrategia = new ComparacionPorPromedio();

    public Alumno(string n, int d, int l, decimal p, IEstrategia comp = null) : base(n, d)
    {
        legajo = l;
        promedio = p;
        estrategia = comp ?? new ComparacionPorPromedio();
    }

    public void setEstrategia(IEstrategia nueva) { estrategia = nueva; }
    public IEstrategia getEstrategia() => estrategia;

    public int getLegajo() => legajo;
    public decimal getPromedio() => promedio;

    public override string ToString()
        => $"{getNombre()} – DNI: {getDNI()}, Legajo: {getLegajo()}, Promedio: {getPromedio():F2}";

    public override bool sosIgual(IComparable c) => estrategia.sosIgual(this, c);
    public override bool sosMenor(IComparable c) => estrategia.sosMenor(this, c);
    public override bool sosMayor(IComparable c) => estrategia.sosMayor(this, c);
}
