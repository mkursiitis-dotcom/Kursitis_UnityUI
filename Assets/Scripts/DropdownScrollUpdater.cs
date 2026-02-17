using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownScrollUpdater : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public TextMeshProUGUI scrollText;

    void Start()
    {
        dropdown.onValueChanged.AddListener(UpdateScrollText);
        UpdateScrollText(dropdown.value); // Set initial text
    }

    void UpdateScrollText(int index)
    {
        switch (index)
        {
            case 0:
                scrollText.text = "Shrek is a 2001 American animated fantasy comedy film directed by Andrew Adamson and Vicky Jenson, and written by Ted Elliott, Terry Rossio, Joe Stillman, and Roger S. H. Schulman, loosely based on the 1990 children's picture book Shrek! by William Steig. It is the first in the Shrek film series, and stars Mike Myers, Eddie Murphy, Cameron Diaz and John Lithgow. In the film, an embittered ogre named Shrek (voiced by Myers) finds his home in the swamp overrun by fairy tale creatures banished by the obsessive ruler Lord Farquaad (Lithgow). With the help of Donkey (Murphy), Shrek makes a pact with Farquaad to rescue Princess Fiona (Diaz) in exchange for regaining control of his swamp.";
                break;

            case 1:
                scrollText.text = "Princess Fiona is a fictional character in DreamWorks' Shrek franchise. One of the film series' main characters, Fiona first appears in Shrek (2001) as a beautiful princess cursed to transform into an ogre at night. She is initially determined to break the enchantment by kissing a prince or knight, only to meet and fall in love with Shrek, an ogre, instead. The character's origins and relationships with other characters are further explored in subsequent films: she introduces her new husband, Shrek, to her parents in Shrek 2 (2004); becomes a mother by Shrek the Third (2007); and is an empowered warrior in Shrek Forever After (2010), much of which takes place in an alternate reality in which Fiona and Shrek never meet.";
                break;

            case 2:
                scrollText.text = "Donkey is a fictional character created by William Steig and adapted by DreamWorks Animation for the Shrek franchise. He is voiced by Eddie Murphy. Donkey is an anthropomorphic donkey and his appearance is modeled after a miniature donkey named Perry. He is depicted with grey fur, brown eyes, and a black mane. In the franchise, he is the sidekick and best friend of Shrek, husband to Dragon, and father to a litter of Dronkeys (Dragon-Donkeys). As the series' comic relief character, Donkey is well-regarded by critics for his humor, wisdom, energetic nature and Murphy's performance.";
                break;
        }
    }
}