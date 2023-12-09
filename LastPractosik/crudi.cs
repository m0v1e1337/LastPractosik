namespace LastPractosik;

internal interface crudi
{
    void Create(List<Polzovatel>? users, jsonchiki json);
    void Read(List<Polzovatel>? users, Polzovatel user, int posit);
    void Update();
    void Delete(List<Polzovatel>? users, int posit);
}

internal interface jsonchiki
{
    static abstract List<Polzovatel>? Load();
    static abstract void Save(List<Polzovatel> users);
}