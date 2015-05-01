var container,
    section,
    section2;

require(['factory'], function (factory) {
    container = factory.getContainer();    
    document.body.appendChild(container.element);
});

function addSection(sectionTitle) {
    require(['factory'], function (factory) {
        container.addSection(factory.getSection(sectionTitle));
    });
}

function addItem(itemTitle, sectionIndex) {
    require(['factory'], function (factory) {
        container.sections[sectionIndex].addItem(factory.getItem(itemTitle));
    });
}