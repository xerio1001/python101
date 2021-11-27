<?php
    $username = $_POST="{['usern']}";
    $password = $_POST="{['pw']}";
?>

<html>
<link href="style_logged_in.css" rel="stylesheet" type="text/css">
<title>Log in</title>
<body>

    <div id="placeholder_main">
    <?php
        if($username == "xerio1001" && $password === "123"){
        print 
        ?> 
            <h4 class="title">You are succesfully logged in!</h4> 
        <?php
        ;
        else 
        print 'Sorry, try again <a href="index.html">here</a>';
        }
    ?>
   </div>
   
</body>
</html>