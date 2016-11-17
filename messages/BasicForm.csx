using System;
using Microsoft.Bot.Builder.FormFlow;

/*
public enum CarOptions { Convertible = 1, SUV, EV };
public enum ColorOptions { Red = 1, White, Blue };
*/
public enum PreferredTopicOptions { Kultúra = 1, Sport, Szórakozás, Politika, Technológia, Üzlet };
public enum PreferredDayOptions { Hétfő = 1, Kedd, Szerda, Csütörtök, Péntek, Szombat, Vasárnap };
public enum PreferredTimeOfDayOptions { Reggel = 1, Napközben, Este };

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    /*
    [Prompt("Hi! What is your {&}?")]
    public string Name { get; set; }

    [Prompt("Please select your favorite car type {||}")]
    public CarOptions Car { get; set; }

    [Prompt("Please select your favorite {&} {||}")]
    public ColorOptions Color { get; set; }
    */

    [Prompt("Helló! Mi a neved?")]
    public string Name { get; set; }

    [Prompt("Melyik téma érdekel a legjobban? Többet is kiválaszthatsz. {||}")]
    public List<PreferredTopicOptions> PreferredTopic { get; set; }

    [Prompt("Melyik nap a legalkalmasabb? Többet is kiválaszthatsz. {||}")]
    public List<PreferredDayOptions> PreferredDay { get; set; }

    [Prompt("Melyik napszakban érsz rá leginkább? Többet is kiválaszthatsz. {||}")]
    public List<PreferredTimeOfDayOptions> PreferredTimeOfDay { get; set; }

    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
