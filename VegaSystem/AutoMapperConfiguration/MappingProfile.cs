namespace VegaSystem.AutoMapperConfiguration
{
    using AutoMapper;
    using VegaSystem.Entities;
    using VegaSystem.Resources;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}