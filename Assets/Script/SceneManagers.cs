using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    //Bottom Button
    public void Buka_Learn()
    {
        SceneManager.LoadScene("Learn");
        Debug.Log("Learn");
    }
    public void Buka_Leaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
        Debug.Log("Leaderboard");
    }
    public void Buka_Community()
    {
        SceneManager.LoadScene("Community");
        Debug.Log("Community");
    }

    public void Buka_Profile()
    {
        SceneManager.LoadScene("Profile");
        Debug.Log("Profile");
    }

    public void Buka_Settings()
    {
        SceneManager.LoadScene("Settings");
        Debug.Log("Settings");
    }

    public void Buka_Pembuka()
    {
        SceneManager.LoadScene("Pembuka");
        Debug.Log("Pembuka");
    }

    public void Buka_Iklan()
    {
        SceneManager.LoadScene("Reward");
        Debug.Log("Nonton Iklan");
    }

    public void Backto_Profile()
    {
        SceneManager.LoadScene("Profile");
        Debug.Log("Back to Profile");
    }

    //Learning Page to Matery List
    public void Learn_Prolog()
    {
        SceneManager.LoadScene("Learn_Prolog");
        Debug.Log("Prolog");
    }
    public void Learn_Hardware()
    {
        SceneManager.LoadScene("Learn_Hardware");
        Debug.Log("Hardware");
    }
    public void Learn_Software()
    {
        SceneManager.LoadScene("Learn_Software");
        Debug.Log("Software");
    }
    public void Learn_Network()
    {
        SceneManager.LoadScene("Learn_Network");
        Debug.Log("Network");
    }

    public void Learn_Languages()
    {
        SceneManager.LoadScene("Learn_Languages");
        Debug.Log("Languages");
    }

    public void Learn_Website()
    {
        SceneManager.LoadScene("Learn_Website");
        Debug.Log("Website");
    }

    public void Learn_HTML()
    {
        SceneManager.LoadScene("Learn_HTML");
        Debug.Log("HTML");
    }

    public void Learn_CSS()
    {
        SceneManager.LoadScene("Learn_CSS");
        Debug.Log("CSS");
    }

    //Matery List Page to Learn Matery
    //Matery : Prolog
    public void Learn_What_is_Technology()
    {
        SceneManager.LoadScene("Learn_Matery_Prolog");
        Debug.Log("What is Technology?");
    }

    public void Learn_Device()
    {
        SceneManager.LoadScene("Learn_Matery_Device");
        Debug.Log("Device?");
    }

    public void Learn_Introduce_Computer()
    {
        SceneManager.LoadScene("Learn_Matery_IntroComp");
        Debug.Log("Introduce Computer?");
    }

    public void Learn_Example()
    {
        SceneManager.LoadScene("Learn_Matery_Example");
        Debug.Log("Example Technology in IRL?");
    }

    public void Exam_Prologue()
    {
        SceneManager.LoadScene("Exam_Topic_Prologue");
        Debug.Log("Try the Exam for Prologue!!");
    }

    //Matery : Hardware
    public void Learn_Hardware_Explaination()
    {
        SceneManager.LoadScene("Learn_Matery_HardExplaination");
        Debug.Log("Hardware Explaination!");
    }

    public void Learn_Hardware_Function()
    {
        SceneManager.LoadScene("Learn_Matery_HardFunction");
        Debug.Log("Hardware Function!");
    }

    public void Learn_HardTypes()
    {
        SceneManager.LoadScene("Learn_Matery_HardType");
        Debug.Log("Hardware Variety!");
    }

    public void Learn_Hardware_Example()
    {
        SceneManager.LoadScene("Learn_Matery_HardExample");
        Debug.Log("Example Hardware in IRL?");
    }

    public void Exam_Hardware()
    {
        SceneManager.LoadScene("Exam_Topic_Hardware");
        Debug.Log("Try the Exam for Hardware!!");
    }

    //Matery : Software
    public void Learn_Software_Explaination()
    {
        SceneManager.LoadScene("Learn_Matery_SoftExplaination");
        Debug.Log("Software Explaination!");
    }

    public void Learn_Software_Function()
    {
        SceneManager.LoadScene("Learn_Matery_SoftFunction");
        Debug.Log("Software Function!");
    }

    public void Learn_Software_Type()
    {
        SceneManager.LoadScene("Learn_Matery_SoftType");
        Debug.Log("Software Type!");
    }

    public void Learn_Software_Example()
    {
        SceneManager.LoadScene("Learn_Matery_SoftExample");
        Debug.Log("Example Software in IRL?");
    }

    public void Exam_Software()
    {
        SceneManager.LoadScene("Exam_Topic_Software");
        Debug.Log("Try the Exam for Software!!");
    }

    //Matery : Network
    public void Learn_Network_Explaination()
    {
        SceneManager.LoadScene("Learn_Matery_NetExplaination");
        Debug.Log("Hardware Explaination!");
    }

    public void Learn_Network_Function()
    {
        SceneManager.LoadScene("Learn_Matery_NetFunction");
        Debug.Log("Hardware Function!");
    }

    public void Learn_NetworkTypes()
    {
        SceneManager.LoadScene("Learn_Matery_NetType");
        Debug.Log("Hardware Variety!");
    }

    public void Learn_Network_Example()
    {
        SceneManager.LoadScene("Learn_Matery_HardExample");
        Debug.Log("Example Network in IRL?");
    }

    public void Exam_Network()
    {
        SceneManager.LoadScene("Exam_Topics_Network");
        Debug.Log("Try the Exam for Network!!");
    }

    //Matery : Website
    public void Learn_Website_Explaination()
    {
        SceneManager.LoadScene("Learn_Matery_WebExplain");
        Debug.Log("Website Explaination!");
    }

    public void Learn_Website_Struct()
    {
        SceneManager.LoadScene("Learn_Matery_WebStruct");
        Debug.Log("Website Structure!");
    }

    public void Learn_WebsiteUsed()
    {
        SceneManager.LoadScene("Learn_Matery_WebUsedFor");
        Debug.Log("Website Use for?");
    }

    public void Learn_Website_Example()
    {
        SceneManager.LoadScene("Learn_Matery_WebEx");
        Debug.Log("Example Website in IRL?");
    }

    public void Exam_Website()
    {
        SceneManager.LoadScene("Exam_Topics_Website");
        Debug.Log("Try the Exam for Website!!");
    }

    //Matery : Languages
    public void Learn_Languages_Explaination()
    {
        SceneManager.LoadScene("Learn_Matery_SoftExplain");
        Debug.Log("Languages Explaination!");
    }

    public void Learn_Languages_Function()
    {
        SceneManager.LoadScene("Learn_Matery_LanguagesFunction");
        Debug.Log("Languages Function!");
    }

    public void Learn_Languages_Variety()
    {
        SceneManager.LoadScene("Learn_Matery_LanguagesVariety");
        Debug.Log("Languages Variety!");
    }

    public void Learn_Languages_Uses()
    {
        SceneManager.LoadScene("Learn_Matery_ExampleUses");
        Debug.Log("Example Languages in IRL?");
    }

    public void Exam_Languages()
    {
        SceneManager.LoadScene("Exam_Topic_Languages");
        Debug.Log("Try the Exam for Languages!!");
    }

    //Matery : HTML
    public void Learn_HTML_Explaination()
    {
        SceneManager.LoadScene("Learn_Matery_HTMLExplain");
        Debug.Log("HTML Explaination!");
    }

    public void Learn_HTML_Function()
    {
        SceneManager.LoadScene("Learn_Matery_HTMLFunction");
        Debug.Log("HTML Function!");
    }

    public void Learn_HTMLUses()
    {
        SceneManager.LoadScene("Learn_Matery_HTMLUses");
        Debug.Log("HTML Variety!");
    }

    public void Learn_HTML_Example()
    {
        SceneManager.LoadScene("Learn_Matery_HTMLExample");
        Debug.Log("Example HTML in IRL?");
    }

    public void Exam_HTML()
    {
        SceneManager.LoadScene("Exam_Topics_HTML");
        Debug.Log("Try the Exam for HTML!!");
    }

    //Matery : CSS
    public void Learn_CSS_Explaination()
    {
        SceneManager.LoadScene("Learn_Matery_HTMLExplain");
        Debug.Log("HTML Explaination!");
    }

    public void Learn_CSS_Function()
    {
        SceneManager.LoadScene("Learn_Matery_HTMLFunction");
        Debug.Log("HTML Function!");
    }

    public void Learn_CSSUses()
    {
        SceneManager.LoadScene("Learn_Matery_HTMLUses");
        Debug.Log("HTML Variety!");
    }

    public void Learn_CSS_Example()
    {
        SceneManager.LoadScene("Learn_Matery_HTMLExample");
        Debug.Log("Example CSS in IRL?");
    }

    public void Exam_CSS()
    {
        SceneManager.LoadScene("Exam_Topics_CSS");
        Debug.Log("Try the Exam for HTML!!");
    }

    //Topics -> Learning Topic
    public void Topic_LearningTopic()
    {
        SceneManager.LoadScene("Learn_Prolog");
        Debug.Log("Example Technology in IRL?");
    }

    //Topics Back to Learning Topics Tech Basic
    public void WhatisTech_LearningTopics()
    {
        SceneManager.LoadScene("Learn_Topic_TechBasic");
        Debug.Log("Back from What is Tech Topics to Learning Topics?");
    }

    public void Device_LearningTopics()
    {
        SceneManager.LoadScene("Learn_Topic_Device");
        Debug.Log("Back from Device Topics to Learning Topics?");
    }

    public void IntroComp_LearningTopics()
    {
        SceneManager.LoadScene("Learn_Topic_IntroComp");
        Debug.Log("Back from Intro Computer Topics to Learning Topics?");
    }

    public void Example_LearningTopics()
    {
        SceneManager.LoadScene("Learn_Topic_Example");
        Debug.Log("Back from Example Topics to Learning Topics?");
    }

    //Matery back to Topic List Page
    public void Matery_()
    {
        SceneManager.LoadScene("");
        Debug.Log("Back from Matery to Topic Lists?");
    }

    //Learning Topics back to Learn Page
    public void Topics_to_Learn()
    {
        SceneManager.LoadScene("Learn");
        Debug.Log("Back to Learn");
    }
}
