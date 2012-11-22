		(* 5.2.1 *)
let create() = [];;


		(* 5.2.2 *)
let singleton x y = [(x, [y])];;
		
		
		(* 5.2.3 *)
let rec length list = match list with
				| [] -> 0
				| e::l -> length l + 1;;
				
		
		(* 5.2.4 *)
let rec size list = match list with
        			| [] -> 0
        			| (x,y)::liste -> match y with
        							| [] -> size liste
        							| e::l -> size ((x,l)::liste) + 1;;
		
		(* 5.2.5 *)
let rec add key value list = match list with
							| [] -> [(key, [value])]
							| (x,y)::l when key = x -> (x,(value::y))::l
							| e::l -> e::add key value l;;

		
		(* 5.2.6 *)
let rec replace key value list = match list with
							| [] -> [(key, [value])]
							| (x,y)::l when key = x -> (x,[value])::l
							| e::l -> e::add key value l;;		


		(* 5.2.7 *)

let rec get key list = match list with
							| [] -> raise Not_found
							| (x,y)::l when key = x -> (match y with
								| [] -> raise Not_found
								| e::l -> e)
							| e::l -> get key l;;

		
		(* 5.2.8 *)
let rec get_all key list = match list with
							| [] -> raise Not_found
							| (x,y)::l when key = x -> y
							| e::l -> get_all key l;;		

		
		(* 5.2.9 *)
let rec mem k list = match list with
							| [] -> false
							| (a,_)::l when a = k -> true
							| e::l -> mem k l;;

				
		(* 5.2.10 *)
let rec remove key list = match list with
							| [] -> raise Not_found
							| (x,_)::l when x = key -> l
							| e::l -> e::remove key l;;
							
							
		(* 5.3.1 *)
let rec iter f list = match list with
							| [] -> () 
							| (x,y)::liste -> match y with
										| [] -> iter f liste
										| e::l -> f x e ; iter f liste;;
										
										
		(* 5.3.2 *)
let rec map f list = match list with
						| [] -> []
						| (x,y)::liste -> match y with
										| [] -> (x,y)::(map f liste)
										| e::l -> (x,(f x e)::l)::(map f liste);;		
		(* 5.3.3 *)
		
		(* 5.3.4 *)
		
		(* 5.4.1 *)
		
(*-------------------------------------------------------------------------------------------------*)


let l = create ();;
let l = singleton 42 0;;
let l = add 8 4 l;;
let l = add 8 6 l;;
let l = replace 42 8 l;;
get 8 l;;
get_all 8 l;;
mem 4 l;;
mem 8 l;;
remove 8 l;;
let f key value =
	print_int key;
	print_char ' ';
	print_int value;
	print_newline ();;
iter f l ;;
let f2 k v = k + v + 1;;
map f2 l ;;
