"# pet-management" 
v1 APIs
Users
POST /api/users(no auth)
GET /api/users (admin)
GET /api/users/:id (including pets)
PUT /api/users/:id 
DELETE /api/users/:id (including pets)
POST /token (login)

Pets
POST /api/pets
GET /api/pets 
GET /api/pets/:id (including diet)
PUT /api/pets/:id
DELETE /api/pets/:id

Diets
POST /api/diets
GET /api/diets/:id
PUT /api/diets/:id
DELETE /api/diets/:id
