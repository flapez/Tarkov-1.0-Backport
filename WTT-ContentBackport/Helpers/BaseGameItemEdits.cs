using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Utils;
using SPTarkov.Server.Core.Services;
using WTTServerCommonLib.Helpers;

namespace WTTContentBackport.Helpers;

[Injectable(typePriority: OnLoadOrder.PostDBModLoader + 3)]
public class BaseGameItemEdits(
    ISptLogger<BaseGameItemEdits> logger,
    DatabaseService databaseService,
    SlotHelper slotHelper
):IOnLoad
{
    public Task OnLoad()
    {
        EditFilters();
        return Task.CompletedTask;
    }

    private void EditFilters()
    {
        var dbItems = databaseService.GetItems();
        foreach (var (id, item) in dbItems)
        {
            switch (id)
            {
                case "5ae30bad5acfc400185c2dc4":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "68a63d1522b1e0bd360afe67"]);
                    break; //Manually push Delta Pic mount to AR-15 carry handle
                
                case "57ac965c24597706be5f975c":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "688b54a11cef2a61d005273b"]);
                    break; //Manually push RMR mount to Elcans
                
                case "57aca93d2459771f2c7e26db":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "688b54a11cef2a61d005273b"]);
                    break; //Manually push RMR mount to Elcans
                
                case "5c0e2f26d174af02a9625114":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "68caacb4c8ac87b10507c5a6"]);
                    break; //Manually push MK12 top rail to upper receivers
                
                case "55d355e64bdc2d962f8b4569":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "68caacb4c8ac87b10507c5a6"]);
                    break; //Manually push MK12 top rail to upper receivers
                
                case "5c07a8770db8340023300450":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "68caacb4c8ac87b10507c5a6"]);
                    break; //Manually push MK12 top rail to upper receivers
                
                case "59bfe68886f7746004266202":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "68caacb4c8ac87b10507c5a6"]);
                    break; //Manually push MK12 top rail to upper receivers
                
                case "63f5ed14534b2c3d5479a677":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "68caacb4c8ac87b10507c5a6"]);
                    break; //Manually push MK12 top rail to upper receivers
                
                case "5d4405aaa4b9361e6a4e6bd3":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "68caacb4c8ac87b10507c5a6"]);
                    break; //Manually push MK12 top rail to upper receivers
                
                case "5df917564a9f347bc92edca3":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "6932aeebbe542622170428ba",
                        "6936bde84737190b66053bb1"]);
                    break; //Manually push MK12 top rail to upper receivers
                
                case "5dfa397fb11454561e39246c":
                    slotHelper.ModifySlotFilters(item, 0, 0, [
                        "6932aeebbe542622170428ba",
                        "6936bde84737190b66053bb1"]);
                    break; //Manually push MK12 top rail to upper receivers
            }
        }
    }
}