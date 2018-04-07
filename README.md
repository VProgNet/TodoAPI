This small project demonstrate working with api

you can:
	
	JSON get all items from db by using
	GET <adress>:<port>/api/todo
	
	DOCX get all items from db by using
	GET <adress>:<port>/api/todo/doc

	JSON get todo from db
	GET <adress>:<port>/api/todo/<id>
	
	DOCX get todo from db
	GET <adress>:<port>/api/todo/<id>
	
	JSON add new todo task
	POST <adress>:<port>/api/todo
	{
		"name":<task_name>,
		"IsComplete":true|false
	}
		
	JSON Update existing todo
	PUT <adress>:<port>/api/todo/<id>
	{
		"id":<id>
		"name":<task_name>,
		"IsComplete":true|false
	}
		
	JSON Delete existing todo
	DELETE <adress>:<port>/api/todo/<id>
	{
		"id":<id>
	}

	