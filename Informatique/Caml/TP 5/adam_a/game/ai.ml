let play (( pos, j1_or, j2_or):plate) joueur = 
												let joueur_or = if joueur then j1_or else j2_or and 
													adversaire_or = if joueur then j2_or else j1_or in
												let avantage_pos = (if joueur then -pos else pos) and
													avantage_or = if joueur_or > adversaire_or then 1 else if joueur_or < adversaire_or then -1 else 0 in
														if adversaire_or = 0 then 1 else
															if avantage_pos = 0 then
																	if avantage_or = 0 then 10
																	else if avantage_or = 1 then Random.int 5
																	else 0
															else if avantage_pos = -1 then 
																	if avantage_or = -1 then joueur_or
																	else if avantage_or = 1 then adversaire_or
																	else adversaire_or
															else if avantage_or = -1 then Random.int 5
																	else if avantage_or = 1 then joueur_or
																	else 0;; 
													
													
													
												
