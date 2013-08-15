using CivSim1.Lib.World;

namespace CivSim1.Lib.Entities
{
    public class Person : Entity
    {
        public override void Tick(Zone zone)
        {
            // Is there anything dangerous near by?
            // Am I angry or afraid or injered?
            // Am I thirsty or someone important to me thirsty?
            // -- Do I have water?
            // -- Is there some water near by?
            // -- Do I know where some water is?
            // -- How can I find some water or ask or trade?
            // ---- Once I have it, should I use that water?
            // Am I hungry or is someone important to me hungry?
            // -- Do I have food?
            // -- Is there some food near by?
            // -- Do I know where some foor is?
            // -- How can I find some food or ask or trade?
            // ---- Once I have it, should I use that food?
            // Am I too hot or cold or is someone important to me too hot or cold?
            // -- have/near/know/search for shelter, should I use?
            // Am I tired?
            // -- have/near/know/search for shelter, should I use?
            // Am I already doing something?
            // -- Do I know the way?
            // -- Is there a path?
            // ********** I have some free time ************
            // Do I have a shelter?
            // -- Is it getting late, do I need to start going there?
            // Do I have somewhere to store things?
            // -- How does my stockpile look?
            // Do I have a mate?
            // -- have/near/know/search for mate, should I use?
            // Do I have children?
            // -- Do they need anything?
            // Do I need company?
            // Do I need sex?
            // Have I had any ideas?
            // -- Does this idea need any items?
            // -- Can I tell someone about this idea?
            // -- Can I record this idea?
            // Is there something interesting near by?
            // -- Do I know what it is?
            // -- Can I take it?
            // -- does it have value?
            // ---- Do I like it?
            // ---- Does someone important to me like it?
            // ---- Does it belong to someone else?
            // Is anyone asking me to do something?
            // Can some do something for me?
            // Can I record a thought?
            // What problems do I have?
            // What problems do people important to me have?
            // Can I make something useful?
            // -- for me
            // -- for someone important to me
            // -- for fun
            // -- to increase wealth
            // Do I want to see something new?
            // -- do I know where to go?
            // -- am I brave enough?
            // Is the current location good? (Food, water, friends, shelter, danger, things I like)
            // -- If I am going, do I want to take people, ask people, force people to go too?
        }
    }
}