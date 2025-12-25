using AutoMapper;

namespace Notes.Applicationn.Common.Mapping
{
    public interface IMappingWith<T>
    {           
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(T), GetType());
    }
}
