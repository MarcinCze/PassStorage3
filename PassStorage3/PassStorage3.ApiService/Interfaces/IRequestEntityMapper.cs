namespace PassStorage3.ApiService.Interfaces
{
    public interface IRequestEntityMapper<EntityModel>
        where EntityModel : IEntityModel
    {
        EntityModel ToEntityModel();
    }
}
