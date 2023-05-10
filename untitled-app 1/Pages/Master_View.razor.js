export function main() {
    $.ig.RevealSdkSettings.setBaseUrl("https://appbuilder-prf9008b9008.indigo.design/reveal/");

    $.ig.RVDashboard.loadDashboard("Sales", (dashboard) => {
        var revealDashBoard = new $.ig.RevealView("#revealDashBoard");
        revealDashBoard.dashboard = dashboard;
    });
}