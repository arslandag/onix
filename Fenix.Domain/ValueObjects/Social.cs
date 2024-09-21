using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects;
using Fenix.Domain.SharedObjects;

namespace Fenix.Domain.ValueObjects;

public record Social
{
    private Social(SocialType socialType, string url)
    {
        SocialType = socialType;
        Url = url;
    }
    
    public SocialType SocialType { get; }
    public string Url { get;}

    public static Result<Social> Create(SocialType socialType ,string url)
    {
        return new Social(socialType, url);
    }
}