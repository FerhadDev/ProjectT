using UnityEngine;

public class CardScript : MonoBehaviour
{
    bool inSlot = true;
    private Manager manager;
    Animator anim;
    private void Start()
    {
        manager = FindAnyObjectByType<Manager>();
        anim = GetComponent<Animator>();
    }
    public void SlotManager()
    {
        if (inSlot == true)
        {
            inSlot = false;
            print("raula basim");
            print(manager.Empty1);
            if (manager.Empty1 == true)
            {
                anim.SetTrigger("Slot1");
                manager.Empty1 = false;
                print(manager.Empty1);
            }
            else if (manager.Empty2 == true)
            {
                anim.SetTrigger("Slot2");
                manager.Empty2 = false;
                print("Slot2");
            }
            else if (manager.Empty3)
            {
                anim.SetTrigger("Slot3");
                manager.Empty3 = false;
                print("Slot3");
            }
        }
        else
        {
            bool currentBool = anim.GetBool("SelectCard");
            anim.SetBool("SelectCard", !currentBool);
        }
    }
}
