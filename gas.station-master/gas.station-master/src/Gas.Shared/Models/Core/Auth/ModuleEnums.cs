
namespace Gas.Shared.Models.Core.Auth
{
    public enum Modules : short
    {
        Auth = 1,
        Home = 2,
        Device = 3,
        Permission = 4,
        Role = 5,
        User = 6,
    }
    
    public enum ModuleState : byte
    {
        Disabled = 0,
        Active = 1
    }


    public enum ModuleEnum : short
    {
        AuthWeb = 101,
    }
}