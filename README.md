This small project demonstrate working with api

you can:
	
	get all items from db by using
	GET <adress>:<port>/api/todo

	get todo from db
	GET <adress>:<port>/api/todo/<id>
	
	add new todo task
	POST <adress>:<port>/api/todo
	{
		"name":<task_name>,
		"IsComplete":true|false
	}
		
	Update existing todo
	PUT <adress>:<port>/api/todo/<id>
	{
		"id":<id>
		"name":<task_name>,
		"IsComplete":true|false
	}
		
	Delete existing todo
	DELETE <adress>:<port>/api/todo/<id>
	{
		"id":<id>
	}
	