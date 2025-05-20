using Yuri.ArmsMall.Countries;

namespace Yuri.ArmsMall.IdentityCards;

/// <inheritdoc cref="IIdentityCardAppService"/>
public class IdentityCardAppService : ArmsMallAppService, IIdentityCardAppService
{
    private readonly IIdentityCardRepository _identityCardRepository;
    private readonly IdentityCardManager _identityCardManager;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="identityCardRepository"></param>
    /// <param name="identityCardManager"></param>
    public IdentityCardAppService(IIdentityCardRepository identityCardRepository, IdentityCardManager identityCardManager)
    {
        _identityCardRepository = identityCardRepository;
        _identityCardManager = identityCardManager;
    }

    /// <inheritdoc/>
    public async Task<IdentityCardDto> CreateAsync(CreateIdentityCardDto input)
    {
        IdentityCard identityCard = await _identityCardManager.CreateAsync(input.Name, input.Sex, input.Nation, input.Birthday, input.Address, input.Number, input.StartDate, input.EndDate);
        await _identityCardRepository.InsertAsync(identityCard);
        return ObjectMapper.Map<IdentityCard, IdentityCardDto>(identityCard);
    }

    /// <inheritdoc/>
    public async Task UpdateAsync(Guid id, UpdateIdentityCardDto input)
    {
        IdentityCard identityCard = await _identityCardRepository.GetAsync(id);
        identityCard.Name = input.Name;
        identityCard.Sex = input.Sex;
        identityCard.Nation = input.Nation;
        identityCard.Birthday = input.Birthday;
        identityCard.Address = input.Address;
        if (identityCard.Number != input.Number) { await _identityCardManager.ChangeNumberAsync(identityCard, input.Number); }
        identityCard.StartDate = input.StartDate;
        identityCard.EndDate = input.EndDate;
        await _identityCardRepository.UpdateAsync(identityCard);
    }

    /// <inheritdoc/>
    public async Task<List<IdentityCardDto>> GetListAsync()
    {
        List<IdentityCard> list = await _identityCardRepository.GetListAsync();
        return ObjectMapper.Map<List<IdentityCard>, List<IdentityCardDto>>(list);
    }
}
