namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 
/// </summary>
public class IdentityCardAppService : ArmsMallAppService, IIdentityCardAppService
{
    private readonly IIdentityCardRepository _identityCardRepository;
    private readonly IdentityCardManager _identityCardManager;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="IdentityCardRepository"></param>
    /// <param name="IdentityCardManager"></param>
    public IdentityCardAppService(IIdentityCardRepository IdentityCardRepository, IdentityCardManager IdentityCardManager)
    {
        _identityCardRepository = IdentityCardRepository;
        _identityCardManager = IdentityCardManager;
    }

    /// <inheritdoc/>
    public async Task<IdentityCardDto> CreateAsync(CreateIdentityCardDto input)
    {
        IdentityCard identityCard = await _identityCardManager.CreateAsync(input.Name, input.Sex, input.Nation, input.Birthday, input.Address, input.Number, input.StartDate, input.EndDate);
        await _identityCardRepository.InsertAsync(identityCard);
        return ObjectMapper.Map<IdentityCard, IdentityCardDto>(identityCard);
    }
}
