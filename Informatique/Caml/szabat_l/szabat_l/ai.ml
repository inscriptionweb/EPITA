
let play plate joueur = 
					let plate = plate_to_plate2 plate in
					let joueur_or = if joueur then plate.joueur1_or else plate.joueur2_or and
						adversaire_or = if joueur then plate.joueur2_or else plate.joueur1_or in
							let avantage_pos = (if joueur then -plate.position_bouchon else plate.position_bouchon) and
							    avantage_or = if joueur_or > adversaire_or then 1 else if joueur_or < adversaire_or then -1 else 0 in
							if adversaire_or = 0 then 1 else
								if avantage_pos = 0 then
									if avantage_or = 0 then Random.int 5
									else if avantage_or = 1 then Random.int 5
									else 0
								else if avantage_pos = -1 then 
									if avantage_or = -1 then joueur_or
									else if avantage_or = 1 then adversaire_or
									else adversaire_or
								else if avantage_or = -1 then 0
									else if avantage_or = 1 then joueur_or
									else 0;;