

//original code
if (comboBox3.SelectedItem.ToString() == "Distance" && comboBox2.SelectedItem.ToString() == "Speed of light")
{
var3 = textBox3.Text;

        distance = Convert.ToDecimal(var1);
          
        time = distance / speedOfLight;
        var3 = time.ToString();
        label4.Text = var3;
        
    }




//my suggested fix

    if (comboBox3.SelectedItem.ToString() == "Distance" && comboBox2.SelectedItem.ToString() == "Speed of light")
{
//remove var3 = textBox3.text as it's not used in this block of code 
//var3 = textBox3.Text;


//var1 isn't given a number in this block, so replace "textbox2.text" below with the correct box
        distance = Convert.ToDecimal(textbox2.text);
          
        time = distance / speedOfLight;
        var3 = time.ToString();
        label4.Text = var3;
        
    }
