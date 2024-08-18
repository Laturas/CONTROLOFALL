use actix_web::post;
use actix_web::{
    get, web, App, HttpResponse, HttpServer, Responder
};
use std::io::Write;
use std::fs::{self, File, OpenOptions};

const ELEMENTS: [&str; 10] = ["imperfectPastStatus","breakMeStatus","paranoidStatus","theoremsAndDreamsStatus","powerCubeStatus","connectionsStatus","lostStatus","silentClubstepStatus","curtainStatus","reconstructedStatus"];
static mut BOOLS: [bool; 10] = [false,false,false,false,false,false,false,false,false,false]; // Yeah this'll cause a data race, I don't care!

#[get("/")]
async fn user_info() -> impl Responder {
    let status_list = fs::read_to_string("status_report.json").unwrap();
    let mut linky = ",\n\"linkylinky\":\"hi.com\"";
    unsafe {for boo in BOOLS {
        if !boo {
            linky = ",\n\"linkylinky\":\"MAINTAINCONTROL\"";
        }
    }}

    HttpResponse::Ok().append_header(("Access-Control-Allow-Origin", "*")).body(format!("{{{status_list}{linky}}}"))
}

#[post("/{key}/")]
async fn attempt_update_key(key: web::Path<String>) -> impl Responder {
    let key = key.into_inner();
    if key == "NeverHoldingBack" {
        return HttpResponse::Ok().append_header(("Access-Control-Allow-Origin", "*")).body(format!("FinalLink"));
    }
    println!("{}",key);
    let index: usize = match key.as_str() {
        "MemoryMerge" => 0,
        "LosingMyself" => 1,
        "RUNNINGINCIRCLES" => 2,
        "MATHMAJOR" => 3,
        "PowerlessObject" => 4,
        "WeAreRebornWithin" => 5,
        "SeaLife" => 6,
        "ImHappyIHaveYou" => 7,
        "DoIKnowHowIWork" => 8,
        "PARANEOPLASTIC" => 9,
        _ => 20
    };
    if index == 20 {return HttpResponse::Ok().body(format!("Nice try :3"));}
    let _ = File::create("status_report.json").unwrap();
    unsafe {BOOLS[index] = true;}

    let mut file = OpenOptions::new().write(true).append(true).open("status_report.json").unwrap();
    //let _ = file.write_all("{\n".as_bytes());
    let mut i = 0;
    for element in ELEMENTS {
        let _ = file.write_all("\"".as_bytes());
        let _ = file.write_all(element.as_bytes());
        let _ = file.write_all("\"".as_bytes());
        unsafe {
            if !BOOLS[i] {
                let _ = file.write_all(":\"unsolved\"".as_bytes());
                if i != ELEMENTS.len() - 1 {let _ = file.write_all(",\n".as_bytes());}
            }
            else {
                let _ = file.write_all(":\"solved\"".as_bytes());
                if i != ELEMENTS.len() - 1 {let _ = file.write_all(",\n".as_bytes());}
            }
        }
        i += 1;
    }
    //let _ = file.write_all("\n}".as_bytes());

    HttpResponse::Ok().append_header(("Access-Control-Allow-Origin", "*")).body(format!("Success!"))
}

#[actix_web::main]
async fn main() -> std::io::Result<()> {
    HttpServer::new(|| {
        App::new().service((user_info, attempt_update_key))
    })
    .bind("127.0.0.1:8080")?
    .run()
    .await
}