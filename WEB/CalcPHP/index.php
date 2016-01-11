<!DOCTYPE html>
<html> 
 <head> 
  <title>Калькулятор</title> 
 </head> 
 <body> 

 <?php 
     $result = "";
     if(array_key_exists("x", $_POST)){
          $a=$_POST['action']; 
          $x=$_POST['x']; 
          $y=$_POST['y']; 
          
              if($a=="+") 
               $result=$x+$y; 
              else if($a=="-") 
               $result=$x-$y; 
              else if($a=="*") 
               $result=$x*$y; 
              else if($a=="/" 
                      && $y!=0)
               $result=$x/$y; 
               
     }

 ?> 

  <form action="calc_simple.php" method=POST> 
   Введите х: <input type=text name=x><br/> 
   Введите у: <input type=text name=y><br/> 
   Выберите действие: 
   <select name=action> 
    <option value="+">х+у</option> 
    <option value="-">х-у</option> 
    <option value="*">х*у</option> 
    <option value="/">х/у</option> 
   
   </select><br/> 
   <input type=submit value="Считай"> <span><?php echo($result);?></span>
  </form> 
 </body> 
</html>


