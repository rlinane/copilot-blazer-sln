namespace copilot_blazer.Data;

//create a class to hold resume data
public class Resume
{
    //create a property to hold the name
    public string? Name { get; set; } = "Richard James Linane";

    //create a property to hold the address
    public string? Address { get; set; } = "147 Stanavage Road, Colchester, CT 06415";

    //create a property to hold the phone number
    public string? Phone { get; set; } = "(860) 537-6571";

    //create a property to hold the cell phone number
    public string? CellPhone { get; set; } = "(860) 918-6590";

    //create a property to hold the email address
    public string? Email { get; set; } = "rlinane@gmail.com";

    public string? LinkedIn { get; set; } = "https://www.linkedin.com/in/richard-linane-9a1b1b1b/";

    //create a property to hold the summary
    public string? Summary { get; set; }

    //create a property to hold the education
    public string? Education { get; set; }

    //create a property to hold the experience
    public string? Experience { get; set; }

    //create a property to hold the skills
    public string? Skills { get; set; }

    //create a property to hold the projects
    public string? Projects { get; set; }

    //create a property to hold the certifications
    public string? Certifications { get; set; } = "AINS (Associate in General Insurance), ARM (Associate in Risk Management), AU (Associate in Underwriting), and CPCU (Chartered Property Casualty Underwriter) SAFe 5 Agilist (Scaled Agile Framework)";

    //create a property to hold the awards
    public string? Awards { get; set; } = "Selective Gold Award Recepiant, 2014-2023";

    //create a property to hold the languages
    public string? Languages { get; set; } = "English";

    //create a property to hold the hobbies
    public string? Hobbies { get; set; } = "Golf, Skiing, Hiking, Camping, Fishing, Kayaking, Biking, Running, Swimming, Reading, Writing, Programming, and Gaming";

    //create a property to hold the references
    public string? References { get; set; } = "Available upon request";

    //create a property to hold the about section
    public string? About { get; set; } = "I am a software developer with a background in insurance and risk management." +
    "I also have a background in the Mortage Origination, Servicing, and associated services." + 
    "I am currently working on my AZ900 Azure Cloud Certification." +
    "I am a certified SAFe 5 Agilist and a Chartered Property Casualty Underwriter." +
    "I am also hold an Associate in General Insurance, an Associate in Risk Management, and an Associate in Underwriting." +
    "I have been a Selective Gold Award recipient for the past 9 years, which is a recognition of out standing service and expertise.";
}