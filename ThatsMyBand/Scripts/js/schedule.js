function buildSchedule(scheduleEvent, elementId)
{
    // On construit pour les 16 prochains jours
    var today = new Date();

    var innerHtml = "<table>" +
        "<tr> <td> test </td> </tr>" +
        "</table>";

    document.getElementById(elementId).innerHTML = innerHtml;
}

// Méthode d'ajout de jours à une date
function addDaysToDate(old_date, delta_days) {
    // Date plus plus quelques jours 
    var split_date = old_date.split('/');
    // Les mois vont de 0 a 11 donc on enleve 1, cast avec *1 
    var new_date = new Date(split_date[2], split_date[1] * 1 - 1, split_date[0] * 1 + delta_days);
    var new_day = new_date.getDate();
    new_day = ((new_day < 10) ? '0' : '') + new_day; // ajoute un zéro devant pour la forme  
    var new_month = new_date.getMonth() + 1;
    new_month = ((new_month < 10) ? '0' : '') + new_month; // ajoute un zéro devant pour la forme  
    var new_year = new_date.getYear();
    new_year = ((new_year < 200) ? 1900 : 0) + new_year; // necessaire car IE et FF retourne pas la meme chose  
    var new_date_text = new_day + '/' + new_month + '/' + new_year;
    return new_date_text;
}