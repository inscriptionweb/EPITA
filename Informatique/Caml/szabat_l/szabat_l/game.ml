type plate2 = { position_bouchon : int; joueur1_or : int; joueur2_or : int };;

type position_bouchon = int;;
type joueur1_or = int;;
type joueur2_or = int;;

type plate = position_bouchon * joueur1_or * joueur2_or;;

type game_status = Non_termine | Joueur1_vainqueur | Joueur2_vainqueur | Match_nul;;

let plate_to_plate2 (plate:plate) = match plate with
						(a,b,c) -> { position_bouchon = a; joueur1_or = b; joueur2_or = c };;
						
let plate2_to_plate plate2 = (( plate2.position_bouchon, plate2.joueur1_or, plate2.joueur2_or):plate)

let init n = (( 0, n, n):plate);;

let display plate = let plate = plate_to_plate2 plate in
					print_newline();
					print_string "Pl. 1 : "; print_int plate.joueur1_or; print_newline();
					for x = -2 to 2 do
						print_string ("  |  " ^ (if plate.position_bouchon = x then "X" else " ") ^ "  |");
						print_newline();
					done;
					print_string "Pl. 2 : "; print_int plate.joueur2_or; print_newline();
					print_newline();;
					
let update plate (or1,or2) = let plate = plate_to_plate2 plate in
						(( plate.position_bouchon + (if or1 < or2 then 1
											else if or1 > or2 then -1
											else 0),
						plate.joueur1_or - or1,
						plate.joueur2_or - or2 ):plate);;
						
let get_status plate = let plate = plate_to_plate2 plate in
					match plate with
					| plate when plate.position_bouchon = -2 -> Joueur1_vainqueur
					| plate when plate.position_bouchon = 2 -> Joueur2_vainqueur
					| plate when plate.joueur1_or = 0 && plate.joueur2_or = 0 -> Match_nul
					| plate -> Non_termine;;