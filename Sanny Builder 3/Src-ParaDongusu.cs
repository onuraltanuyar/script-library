{$CLEO .CS}

0000: NOPE

CONST 
GIVE_MONEY = 1@
TAKE_MONEY = 2@
END

WHILE TRUE
wait 0 
    IF 
    0AB0: key_pressed 18 // ALT tusu
    THEN
        03FE: set_actor 1@ money 5000 // sinirsiz para dongusu
    ELSE
        0AB1: call_scm_func @TakeMoney 2@ 3000 $result // ms result (milisecond)
        printf "~g~~g~0 - 5000 ARASI PARA DONGUSU (3.000/MS) <!>" -1
    END
wait 10
END

:TakeMoney
wait 0
03FE: set_actor 1@ money 0
wait 3000
