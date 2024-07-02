extends CanvasLayer

func _on_start_game_pressed():
	get_tree().change_scene_to_file("res://main.tscn");

func _on_exit_pressed():
	get_tree().quit();


func _on_continue_pressed():
	var cs_note = $MarginContainer/VBoxContainer/Continue
	var res = cs_note.printCS("AAAAAAAAAAAAAA", 65)

