namespace ApiService.Interfaces
{
    public interface IRequestEntityMapper<EntityModel>
        where EntityModel : IEntityModel
    {
        EntityModel ToEntityModel();
    }
}
