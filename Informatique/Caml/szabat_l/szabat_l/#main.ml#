#use "game.ml";;
#use "ai.ml";;

let ask_int () =
    let str = read_line () in
    let length = String.length str - 1 in
        int_of_string (
            if str.[length] = ';' then
                String.sub str 0 (length - 1)
            else str);;

let get_bet plate ia joueur = let plate2 = plate_to_plate2 plate in
						if ia = false then 
							let bet = ask_int() in
								if (joueur && bet <= plate2.joueur1_or) || (not joueur && bet <= plate2.joueur2_or) && bet >= 0 then bet 
								else invalid_arg "Montant invalide."
						else play plate joueur;;
							
let test_winner status = match status with
					| Non_termine -> false
					| Joueur1_vainqueur -> print_string "Joueur 1 gagne la partie." ; true
					| Joueur2_vainqueur -> print_string "Joueur 2 gagne la partie." ; true
					| Match_nul -> print_string "Match nul" ; true;;
					
let main (ia,joueur) n = let plate = init n in let plate2 = plate_to_plate2 plate in

			let rec tour plate2 =
			display plate2;
			if not (test_winner (get_status plate)) then
			  let bet_j1 = print_string "Joueur 1 mise : "; print_newline() ; get_bet plate (ia && joueur) joueur and 
			      bet_j2 = print_string "Joueur 2 mise : " ; print_newline() ; get_bet plate (ia && not joueur) (not joueur)
				in
						tour (update plate ( bet_j1 , bet_j2 ))
					 in tour plate;;

main (false, false) 100;;
