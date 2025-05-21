using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectMapping;
using Yuri.ArmsMall.Countries;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
    public async Task DeleteAsync(Guid id)
    {
        await _identityCardRepository.DeleteAsync(id);
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
    public async Task<IdentityCardDto> GetAsync(Guid id)
    {
        IdentityCard country = await _identityCardRepository.GetAsync(id);
        return ObjectMapper.Map<IdentityCard, IdentityCardDto>(country);
    }

    /// <inheritdoc/>
    public async Task<List<IdentityCardDto>> GetListAsync()
    {
        List<IdentityCard> list = await _identityCardRepository.GetListAsync();
        return ObjectMapper.Map<List<IdentityCard>, List<IdentityCardDto>>(list);
    }

    /// <inheritdoc/>
    public async Task<PagedResultDto<IdentityCardDto>> GetPagedAsync(GetIdentityCardPagedDto input)
    {
        if (input.Sorting.IsNullOrWhiteSpace()) { input.Sorting = nameof(IdentityCard.CreationTime); }
        (int count, List<IdentityCard> list) = await _identityCardRepository.GetPagedAsync(input.SkipCount, input.MaxResultCount, input.Sorting, input.Filter);
        return new PagedResultDto<IdentityCardDto>(count, ObjectMapper.Map<List<IdentityCard>, List<IdentityCardDto>>(list));
    }
}
