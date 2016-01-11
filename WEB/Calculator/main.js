var firstNumber = 0;
var secondNumber = 0;
var operationSign = "";

function works_with_operator(oper)
{
    if(operationSign == "")
        {
            firstNumber = parseFloat(document.getElementById("screen_TB").value);
            operationSign = oper;
        }
        else
        {
            var numOp = firstNumber+operationSign;
            secondNumber = parseFloat((document.getElementById("screen_TB").value).substring(numOp.length));
            firstNumber = parseFloat(Calc());

            if(oper == "=")
                {
                    operationSign = "";
                    document.getElementById("screen_TB").value = firstNumber;
                }
            else
                {
                    operationSign = oper;
                    secondNumber = 0;
                    document.getElementById("screen_TB").value = firstNumber + operationSign;
                }
        }
}

function Calc()
{
    switch(operationSign)
        {
            case "+":return firstNumber + secondNumber;
            case "-":return firstNumber - secondNumber;
            case "*":return firstNumber * secondNumber;
            case "/":return firstNumber / secondNumber;
        }
    return "Sign error";
}

function OnScreen(some)
{
    screen_TB.value+=some;
}

function op_minus_click(){
    var btnData = '-';
    OnScreen(btnData);
    works_with_operator(btnData);
}
function op_plus_click(){
    var btnData = '+';
    OnScreen(btnData);
    works_with_operator(btnData);
}
function op_mult_click(){
    var btnData = '*';
    OnScreen(btnData);
    works_with_operator(btnData);
}
function op_divide_click(){
    var btnData = '/';
    OnScreen(btnData);
    works_with_operator(btnData);
}

function result_click(){
    var btnData = '=';
    works_with_operator(btnData);
}

function clear_click(){
    screen_TB.value="";
    firstNumber = 0;
    secondNumber = 0;
    operationSign = "";
}

function num_0_click()
{
    var btnData = 0;
    OnScreen(btnData);
}
function num_1_click()
{
    var btnData = 1;
    OnScreen(btnData);
}
function num_2_click()
{
    var btnData = 2;
    OnScreen(btnData);
}
function num_3_click()
{
    var btnData = 3;
    OnScreen(btnData);
}
function num_4_click()
{
    var btnData = 4;
    OnScreen(btnData);
}
function num_5_click()
{
    var btnData = 5;
    OnScreen(btnData);
}
function num_6_click()
{
    var btnData = 6;
    OnScreen(btnData);
}
function num_7_click()
{
    var btnData = 7;
    OnScreen(btnData);
}
function num_8_click()
{
    var btnData = 8;
    OnScreen(btnData);
}
function num_9_click()
{
    var btnData = 9;
    OnScreen(btnData);
}