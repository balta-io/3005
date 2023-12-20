using System.ComponentModel.DataAnnotations;
using JwtStore.Components.Pages.Contexts.SharedContext.Enums;
using JwtStore.Components.Pages.Contexts.SharedContext.ViewModels;

namespace JwtStore.Components.Pages.Contexts.AccountContext.UseCases.Create;

public class ViewModel : BaseViewModel
{
    [Required(ErrorMessage = "Informe o nome")]
    public string Name { get; set; } = string.Empty;
    
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    public string Email { get; set; } = string.Empty;
    
    public string Password { get; set; } = string.Empty;
    
    [Compare("Password", ErrorMessage = "As senhas não conferem")]
    public string ConfirmPassword { get; set; } = string.Empty;

    public EState State { get; set; } = EState.Idle;
}