function load(){
    
    link.style.width = document.documentElement.clientWidth-20 + "px";
    var topBorder = document.documentElement.clientHeight-80;
    link.style.height = document.documentElement.clientHeight-50 + "px";
    var leftBorder = document.documentElement.clientWidth-55;

    callback = function() {
        var incrementX = getRandomInt(-6,6);
        var incrementY = getRandomInt(-6,6);
        var X = event.pageX-25;
        var Y = event.pageY-25;
        var ball = document.createElement('div');
        ball.className = 'ball';
        ball.style.left = X+"px";
        ball.style.top = Y+'px';
        var bll = getRandomInt(40,60);
        ball.style.width = bll+"px";
        ball.style.height = bll+"px";
       // alert(elem);
        link.appendChild(ball);

        setInterval(frame,10);
        var leftDir = incrementX;
            var topDir = incrementY;

        function frame(){
            var x1 = ball.offsetLeft;
            var y1 = ball.offsetTop;

            ball.style.left = x1+leftDir +"px";
            ball.style.top = y1+topDir + "px";

            if( parseInt(ball.style.left)< parseInt(0) || parseInt(ball.style.left)> parseInt(leftBorder)-20)
            {
                leftDir = leftDir*-1 ;
            }
            if( parseInt(ball.style.top)< parseInt(0) || parseInt(ball.style.top) > parseInt(topBorder)-20)
            {
                topDir = topDir*-1 ;
            }
        }
    }
    link.click();
    link.onmousemove = callback;
    link.addEventListener('mousemove',callback,false);
    
//    link.click();
//    link.onlick = callback;
//    link.addEventListener('click', callback,false);
}

function getRandomInt(min, max)//функция рандом от min до max
{
    return Math.floor(Math.random() * (max - min + 1)) + min;
}