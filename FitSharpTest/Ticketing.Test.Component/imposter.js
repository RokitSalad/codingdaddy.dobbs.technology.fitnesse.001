{
    "port": 9999,
    "protocol": "http",
    "stubs": [{
        "responses": [
          { "is": { "statusCode": 201 }}
        ],
        "predicates": [
              {
                  "equals": {
                      "path": "/ticketservice",
                      "method": "POST",
                      "headers": {
                          "Content-Type": "application/json"
                      }
                  }
              }
            ]
        
    }]
}